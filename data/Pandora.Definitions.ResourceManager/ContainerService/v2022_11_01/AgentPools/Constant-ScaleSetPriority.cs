using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerService.v2022_11_01.AgentPools;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ScaleSetPriorityConstant
{
    [Description("Regular")]
    Regular,

    [Description("Spot")]
    Spot,
}
