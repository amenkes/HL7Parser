using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class PolicyTypeAndAmount : BaseField, IPolicyTypeAndAmount
    {
        public override ElementDataType DataType => ElementDataType.PTA;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "PTA.1")]
#endif
}