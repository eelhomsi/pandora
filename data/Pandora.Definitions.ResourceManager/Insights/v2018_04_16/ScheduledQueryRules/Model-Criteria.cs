using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Insights.v2018_04_16.ScheduledQueryRules;


internal class CriteriaModel
{
    [JsonPropertyName("dimensions")]
    public List<DimensionModel>? Dimensions { get; set; }

    [JsonPropertyName("metricName")]
    [Required]
    public string MetricName { get; set; }
}