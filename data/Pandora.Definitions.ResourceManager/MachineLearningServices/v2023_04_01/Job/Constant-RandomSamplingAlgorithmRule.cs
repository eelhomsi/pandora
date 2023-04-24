using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01.Job;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RandomSamplingAlgorithmRuleConstant
{
    [Description("Random")]
    Random,

    [Description("Sobol")]
    Sobol,
}