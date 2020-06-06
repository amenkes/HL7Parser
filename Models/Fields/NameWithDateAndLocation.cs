using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class NameWithDateAndLocation : BaseField, INameWithDateAndLocation
    {
        public override ElementDataType DataType => ElementDataType.NDL;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "NDL.1")]
#endif
}