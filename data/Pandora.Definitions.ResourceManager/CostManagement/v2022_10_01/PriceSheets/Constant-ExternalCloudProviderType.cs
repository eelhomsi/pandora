using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2022_10_01.PriceSheets;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ExternalCloudProviderTypeConstant
{
    [Description("externalBillingAccounts")]
    ExternalBillingAccounts,

    [Description("externalSubscriptions")]
    ExternalSubscriptions,
}