using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class SequenceId : BaseField, ISequenceId
    {
        public override ElementDataType DataType => ElementDataType.SI;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "SI.1")]
#endif
}