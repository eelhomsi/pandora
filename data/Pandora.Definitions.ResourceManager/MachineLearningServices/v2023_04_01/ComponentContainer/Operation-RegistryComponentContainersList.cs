using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01.ComponentContainer;

internal class RegistryComponentContainersListOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new RegistryId();

    public override Type NestedItemType() => typeof(ComponentContainerResourceModel);

    public override Type? OptionsObject() => typeof(RegistryComponentContainersListOperation.RegistryComponentContainersListOptions);

    public override string? UriSuffix() => "/components";

    internal class RegistryComponentContainersListOptions
    {
        [QueryStringName("$skip")]
        [Optional]
        public string Skip { get; set; }
    }
}