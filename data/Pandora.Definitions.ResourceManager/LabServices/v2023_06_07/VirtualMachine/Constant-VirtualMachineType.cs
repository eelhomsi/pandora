using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.LabServices.v2023_06_07.VirtualMachine;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VirtualMachineTypeConstant
{
    [Description("Template")]
    Template,

    [Description("User")]
    User,
}
