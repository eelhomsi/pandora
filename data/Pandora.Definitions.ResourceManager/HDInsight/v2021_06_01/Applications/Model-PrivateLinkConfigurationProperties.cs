using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HDInsight.v2021_06_01.Applications;


internal class PrivateLinkConfigurationPropertiesModel
{
    [JsonPropertyName("groupId")]
    [Required]
    public string GroupId { get; set; }

    [JsonPropertyName("ipConfigurations")]
    [Required]
    public List<IPConfigurationModel> IPConfigurations { get; set; }

    [JsonPropertyName("provisioningState")]
    public PrivateLinkConfigurationProvisioningStateConstant? ProvisioningState { get; set; }
}