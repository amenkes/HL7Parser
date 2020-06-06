using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class FinancialClass : BaseField, IFinancialClass
    {
        public override ElementDataType DataType => ElementDataType.FC;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "FC.1")]
#endif
}