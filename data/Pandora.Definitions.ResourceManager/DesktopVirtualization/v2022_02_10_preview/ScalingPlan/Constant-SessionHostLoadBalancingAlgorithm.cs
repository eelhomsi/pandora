using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DesktopVirtualization.v2022_02_10_preview.ScalingPlan;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SessionHostLoadBalancingAlgorithmConstant
{
    [Description("BreadthFirst")]
    BreadthFirst,

    [Description("DepthFirst")]
    DepthFirst,
}
