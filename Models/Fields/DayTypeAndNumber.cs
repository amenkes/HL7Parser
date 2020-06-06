using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class DayTypeAndNumber : BaseField, IDayTypeAndNumber
    {
        public override ElementDataType DataType => ElementDataType.DTN;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "DTN.1")]
#endif
}