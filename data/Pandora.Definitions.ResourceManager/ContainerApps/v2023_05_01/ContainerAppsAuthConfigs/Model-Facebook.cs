using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerApps.v2023_05_01.ContainerAppsAuthConfigs;


internal class FacebookModel
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("graphApiVersion")]
    public string? GraphApiVersion { get; set; }

    [JsonPropertyName("login")]
    public LoginScopesModel? Login { get; set; }

    [JsonPropertyName("registration")]
    public AppRegistrationModel? Registration { get; set; }
}
