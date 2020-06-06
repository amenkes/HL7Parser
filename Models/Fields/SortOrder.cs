using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class SortOrder : BaseField, ISortOrder
    {
        public override ElementDataType DataType => ElementDataType.SRT;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "SRT.1")]
#endif
}