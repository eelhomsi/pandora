using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HDInsight.v2021_06_01.Clusters;


internal class DiskEncryptionPropertiesModel
{
    [JsonPropertyName("encryptionAlgorithm")]
    public JsonWebKeyEncryptionAlgorithmConstant? EncryptionAlgorithm { get; set; }

    [JsonPropertyName("encryptionAtHost")]
    public bool? EncryptionAtHost { get; set; }

    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    [JsonPropertyName("msiResourceId")]
    public string? MsiResourceId { get; set; }

    [JsonPropertyName("vaultUri")]
    public string? VaultUri { get; set; }
}