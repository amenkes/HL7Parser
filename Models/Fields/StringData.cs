using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class StringData : BaseField, IStringData
    {
        public override ElementDataType DataType => ElementDataType.ST;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "ST.1")]
#endif
}