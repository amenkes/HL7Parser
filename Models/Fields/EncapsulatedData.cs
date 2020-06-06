using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class EncapsulatedData : BaseField, IEncapsulatedData
    {
        public override ElementDataType DataType => ElementDataType.ED;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "ED.1")]
#endif
}