using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.LabServices.v2023_06_07.Image;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OsTypeConstant
{
    [Description("Linux")]
    Linux,

    [Description("Windows")]
    Windows,
}
