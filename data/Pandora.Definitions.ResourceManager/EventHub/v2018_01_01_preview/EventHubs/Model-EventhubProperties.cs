using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.EventHubs
{

    internal class EventhubPropertiesModel
    {
        [JsonPropertyName("captureDescription")]
        public CaptureDescriptionModel? CaptureDescription { get; set; }

        [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("messageRetentionInDays")]
        public int? MessageRetentionInDays { get; set; }

        [JsonPropertyName("partitionCount")]
        public int? PartitionCount { get; set; }

        [JsonPropertyName("partitionIds")]
        public List<string>? PartitionIds { get; set; }

        [JsonPropertyName("status")]
        public EntityStatusConstant? Status { get; set; }

        [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
    }
}
