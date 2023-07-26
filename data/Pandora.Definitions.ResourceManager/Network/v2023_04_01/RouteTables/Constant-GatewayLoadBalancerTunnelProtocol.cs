using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.RouteTables;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum GatewayLoadBalancerTunnelProtocolConstant
{
    [Description("Native")]
    Native,

    [Description("None")]
    None,

    [Description("VXLAN")]
    VXLAN,
}
