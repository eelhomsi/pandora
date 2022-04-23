package generator

import "fmt"

func (s *ServiceGenerator) clients(data ServiceGeneratorData) error {
	if err := s.writeToPath(data.outputPath, "client.go", clientsTemplater{}, data); err != nil {
		return fmt.Errorf("templating client: %+v", err)
	}

	return nil
}
