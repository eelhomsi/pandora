using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.VirtualWANs;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VirtualWanSecurityProviderTypeConstant
{
    [Description("External")]
    External,

    [Description("Native")]
    Native,
}
