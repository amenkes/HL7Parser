using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class JobCodeClass : BaseField, IJobCodeClass
    {
        public override ElementDataType DataType => ElementDataType.JCC;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "JCC.1")]
#endif
}