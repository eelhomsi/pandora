package pipeline

import (
	"fmt"
	"log"
	"sort"

	"github.com/hashicorp/go-hclog"
	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/components/discovery"
	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/models"
)

func runImporter(input RunInput, generationData []discovery.ServiceInput, swaggerGitSha string) error {
	// group the API Versions by Service
	dataByServices := make(map[string][]discovery.ServiceInput)
	for _, v := range generationData {
		existing, ok := dataByServices[v.ServiceName]
		if !ok {
			existing = append(existing, v)
			dataByServices[v.ServiceName] = existing
			continue
		} else {
			existing = append(existing, v)
			dataByServices[v.ServiceName] = existing
			continue
		}
	}

	// sort these so it's easier for parsing/tracing
	serviceNames := make([]string, 0)
	for serviceName := range dataByServices {
		serviceNames = append(serviceNames, serviceName)
	}
	sort.Strings(serviceNames)

	// then parse/process the data for each of the API Versions for each service
	for _, serviceName := range serviceNames {
		serviceDetails := dataByServices[serviceName]
		logger := input.Logger.Named(fmt.Sprintf("Importer for Service %q", serviceName))
		if err := runImportForService(input, serviceName, serviceDetails, logger, swaggerGitSha); err != nil {
			return fmt.Errorf("parsing data for Service %q: %+v", serviceName, err)
		}
	}

	return nil
}

func runImportForService(input RunInput, serviceName string, apiVersionsForService []discovery.ServiceInput, logger hclog.Logger, swaggerGitSha string) error {
	task := pipelineTask{}
	apiVersions := make([]models.AzureApiDefinition, 0)
	rootNamespace := ""
	var resourceProvider *string
	var terraformPackageName *string

	for _, apiVersion := range apiVersionsForService {
		versionLogger := logger.Named(fmt.Sprintf("Importer for API Version %q", apiVersion.ApiVersion))

		// populate the service information based on this api version
		if rootNamespace == "" {
			rootNamespace = apiVersion.RootNamespace
		}
		if rootNamespace != "" && rootNamespace != apiVersion.RootNamespace {
			// TODO: this is possible, just requires refactoring this.
			return fmt.Errorf("different root namespaces were found for different api versions for the same service - previously found %q but got %q", rootNamespace, apiVersion.RootNamespace)
		}
		if resourceProvider == nil && apiVersion.ResourceProvider != nil {
			rpName := *apiVersion.ResourceProvider
			resourceProvider = &rpName
		}
		if terraformPackageName == nil && apiVersion.TerraformServiceDefinition != nil {
			packageName := apiVersion.TerraformServiceDefinition.TerraformPackageName
			terraformPackageName = &packageName
		}

		versionLogger.Trace("Task: Parsing Data..")
		dataForApiVersion, err := task.parseDataForApiVersion(apiVersion, versionLogger)
		if err != nil {
			return fmt.Errorf("parsing data for Service %q / Version %q: %+v", apiVersion.ServiceName, apiVersion.ApiVersion, err)
		}
		if dataForApiVersion == nil {
			// e.g. service is ignored
			versionLogger.Trace("no data returned - ignored etc - skipping")
			return nil
		}

		// generate the schema
		versionLogger.Trace(fmt.Sprintf("generating Terraform Details for Service %q / Version %q", apiVersion.ServiceName, apiVersion.ApiVersion))
		terraformDetails, err := task.generateTerraformDetails(apiVersion, dataForApiVersion, versionLogger.Named("TerraformDetails"))
		if err != nil {
			return fmt.Errorf(fmt.Sprintf("generating Terraform Details for Service %q / Version %q: %+v", apiVersion.ServiceName, apiVersion.ApiVersion, err))
		}
		// TODO: stuff n things @stephybun
		log.Printf("Got Stuff: %+v", terraformDetails)

		// build the tests
		versionLogger.Trace(fmt.Sprintf("generating Terraform Tests for Service %q / Version %q", apiVersion.ServiceName, apiVersion.ApiVersion))
		terraformDetails, err = task.generateTerraformTests(apiVersion, *terraformDetails, versionLogger.Named("TerraformTests"))
		if err != nil {
			return fmt.Errorf(fmt.Sprintf("generating Terraform Tests for Service %q / Version %q: %+v", apiVersion.ServiceName, apiVersion.ApiVersion, err))
		}

		versionLogger.Trace("Task: Applying Overrides from Existing Data..")
		dataForApiVersion, err = task.applyOverridesFromExistingData(*dataForApiVersion, input.DataApiEndpoint, versionLogger)
		if err != nil {
			return fmt.Errorf("applying overrides for existing data for Service %q / Version %q: %+v", apiVersion.ServiceName, apiVersion.ApiVersion, err)
		}

		versionLogger.Trace("Task: Generating Data API Definitions..")
		if err := task.generateApiDefinitions(apiVersion, *dataForApiVersion, swaggerGitSha, versionLogger); err != nil {
			return fmt.Errorf("generating API Definitions for Service %q / Version %q: %+v", apiVersion.ServiceName, apiVersion.ApiVersion, err)
		}

		// finally once we have all of the information for this API version, add it to the list so that we can
		// generate the canonical "Terraform Data Sources/Resources" for this Service
		apiVersions = append(apiVersions, *dataForApiVersion)
	}

	logger.Trace("Task: Generating Service Definitions..")
	if err := task.generateServiceDefinitions(serviceName, input.OutputDirectory, rootNamespace, swaggerGitSha, resourceProvider, terraformPackageName, apiVersions, logger.Named("Service Definitions")); err != nil {
		return fmt.Errorf("generating Service Definitions for %q: %+v", serviceName, err)
	}

	return nil
}
