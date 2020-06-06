using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class OccurrenceSpanCodeAndDate : BaseField, IOccurrenceSpanCodeAndDate
    {
        public override ElementDataType DataType => ElementDataType.OSP;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "OSP.1")]
#endif
}