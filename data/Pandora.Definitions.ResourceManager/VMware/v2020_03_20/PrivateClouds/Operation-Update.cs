using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.VMware.v2020_03_20.PrivateClouds
{
    internal class UpdateOperation : Operations.PatchOperation
    {
        public override bool LongRunning()
        {
            return true;
        }

        public override object? RequestObject()
        {
            return new PrivateCloudUpdateModel();
        }

        public override ResourceID? ResourceId()
        {
            return new PrivateCloudId();
        }

        public override object? ResponseObject()
        {
            return new PrivateCloudModel();
        }


    }
}
