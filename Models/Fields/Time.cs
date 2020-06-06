using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class Time : BaseField, ITime
    {
        public override ElementDataType DataType => ElementDataType.TM;
    }

#if TODO
    [CombineOrder(Order = 1, Name = ".1")]
#endif
}