using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class GeneralTimingSpecification : BaseField, IGeneralTimingSpecification
    {
        public override ElementDataType DataType => ElementDataType.GTS;
    }

#if TODO
    [CombineOrder(Order = 1, Name = ".1")]
#endif
}