using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class DailyDeductibleInformation : BaseField, IDailyDeductibleInformation
    {
        public override ElementDataType DataType => ElementDataType.DDI;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "DDI.1")]
#endif
}