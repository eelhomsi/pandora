using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.AuthorizationRulesEventHubs
{

    internal class AuthorizationRulePropertiesModel
    {
        [JsonPropertyName("rights")]
        [Required]
        public List<AccessRightsConstant> Rights { get; set; }
    }
}
