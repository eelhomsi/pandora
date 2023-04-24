using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01.ModelContainer;

internal class Definition : ResourceDefinition
{
    public string Name => "ModelContainer";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new RegistryModelContainersCreateOrUpdateOperation(),
        new RegistryModelContainersDeleteOperation(),
        new RegistryModelContainersGetOperation(),
        new RegistryModelContainersListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AssetProvisioningStateConstant),
        typeof(ListViewTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ModelContainerModel),
        typeof(ModelContainerResourceModel),
    };
}