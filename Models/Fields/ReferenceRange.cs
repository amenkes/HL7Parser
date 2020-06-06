using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class ReferenceRange : BaseField, IReferenceRange
    {
        public override ElementDataType DataType => ElementDataType.RFR;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "RFR.1")]
#endif
}