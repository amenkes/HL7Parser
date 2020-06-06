using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class OccurrenceCodeAndDate : BaseField, IOccurrenceCodeAndDate
    {
        public override ElementDataType DataType => ElementDataType.OCD;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "OCD.1")]
#endif
}