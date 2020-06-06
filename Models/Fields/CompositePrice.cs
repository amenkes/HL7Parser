using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class CompositePrice : BaseField, ICompositePrice
    {
        public override ElementDataType DataType => ElementDataType.CP;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "CP.1")]
#endif
}