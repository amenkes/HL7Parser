using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class Money : BaseField, IMoney
    {
        public override ElementDataType DataType => ElementDataType.MO;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "MO.1")]
#endif
}