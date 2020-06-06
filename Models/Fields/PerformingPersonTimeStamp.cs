using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class PerformingPersonTimestamp : BaseField, IPerformingPersonTimestamp
    {
        public override ElementDataType DataType => ElementDataType.PPN;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "PPN.1")]
#endif
}