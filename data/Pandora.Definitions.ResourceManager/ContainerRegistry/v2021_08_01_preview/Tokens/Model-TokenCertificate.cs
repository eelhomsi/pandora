using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2021_08_01_preview.Tokens;


internal class TokenCertificateModel
{
    [JsonPropertyName("encodedPemCertificate")]
    public string? EncodedPemCertificate { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("expiry")]
    public DateTime? Expiry { get; set; }

    [JsonPropertyName("name")]
    public TokenCertificateNameConstant? Name { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}