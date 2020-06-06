using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class RepeatInterval : BaseField, IRepeatInterval
    {
        public override ElementDataType DataType => ElementDataType.RI;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "RI.1")]
#endif
}