using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Workloads.v2023_04_01.SAPAvailabilityZoneDetails;

internal class SAPAvailabilityZoneDetailsOperation : Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(SAPAvailabilityZoneDetailsRequestModel);

    public override ResourceID? ResourceId() => new LocationId();

    public override Type? ResponseObject() => typeof(SAPAvailabilityZoneDetailsResultModel);

    public override string? UriSuffix() => "/sapVirtualInstanceMetadata/default/getAvailabilityZoneDetails";


}