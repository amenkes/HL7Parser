using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class MoneyOrPercentage : BaseField, IMoneyOrPercentage
    {
        public override ElementDataType DataType => ElementDataType.MOP;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "MOP.1")]
#endif
}