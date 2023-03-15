using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Orbital.v2022_11_01.ContactProfile;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DirectionConstant
{
    [Description("Downlink")]
    Downlink,

    [Description("Uplink")]
    Uplink,
}