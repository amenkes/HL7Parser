using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class DischargeToLocationAndDate : BaseField, IDischargeToLocationAndDate
    {
        public override ElementDataType DataType => ElementDataType.DLD;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "DLD.1")]
#endif
}