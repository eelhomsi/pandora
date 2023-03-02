using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_10_01_preview.DataConnectors;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DataTypeStateConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}