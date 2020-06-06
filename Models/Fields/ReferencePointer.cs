using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class ReferencePointer : BaseField, IReferencePointer
    {
        public override ElementDataType DataType => ElementDataType.RP;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "RP.1")]
#endif
}