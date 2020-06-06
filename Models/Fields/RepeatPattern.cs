using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class RepeatPattern : BaseField, IRepeatPattern
    {
        public override ElementDataType DataType => ElementDataType.RPT;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "RPT.1")]
#endif
}