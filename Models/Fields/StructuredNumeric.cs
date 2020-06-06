using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class StructuredNumeric : BaseField, IStructuredNumeric
    {
        public override ElementDataType DataType => ElementDataType.SN;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "SN.1")]
#endif
}