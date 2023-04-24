using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StorageCache.v2023_05_01.AscUsages;


internal class ResourceUsageNameModel
{
    [JsonPropertyName("localizedValue")]
    public string? LocalizedValue { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}