using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.EventHub.v2017_04_01.CheckNameAvailabilityNamespaces
{

    internal class CheckNameAvailabilityResultModel
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("nameAvailable")]
        public bool? NameAvailable { get; set; }

        [JsonPropertyName("reason")]
        public UnavailableReasonConstant? Reason { get; set; }
    }
}
