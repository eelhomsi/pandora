using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Resources.v2021_04_01.DeploymentOperations;

internal class ListAtManagementGroupScopeOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new Providers2DeploymentId();

    public override Type NestedItemType() => typeof(DeploymentOperationModel);

    public override Type? OptionsObject() => typeof(ListAtManagementGroupScopeOperation.ListAtManagementGroupScopeOptions);

    public override string? UriSuffix() => "/operations";

    internal class ListAtManagementGroupScopeOptions
    {
        [QueryStringName("$top")]
        [Optional]
        public int Top { get; set; }
    }
}