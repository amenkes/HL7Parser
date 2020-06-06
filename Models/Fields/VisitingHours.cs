using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class VisitingHours : BaseField, IVisitingHours
    {
        public override ElementDataType DataType => ElementDataType.VH;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "VH.1")]
#endif
}