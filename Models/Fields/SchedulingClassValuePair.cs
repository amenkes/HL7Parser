using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class SchedulingClassValuePair : BaseField, ISchedulingClassValuePair
    {
        public override ElementDataType DataType => ElementDataType.SCV;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "SCV.1")]
#endif
}