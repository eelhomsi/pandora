using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.VMware.v2020_03_20.HcxEnterpriseSites
{
    internal class CreateOrUpdateOperation : Operations.PutOperation
    {
        public override object? RequestObject()
        {
            return new HcxEnterpriseSiteModel();
        }

        public override ResourceID? ResourceId()
        {
            return new HcxEnterpriseSiteId();
        }

        public override object? ResponseObject()
        {
            return new HcxEnterpriseSiteModel();
        }


    }
}
