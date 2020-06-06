using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class ValueRange : BaseField, IValueRange
    {
        public override ElementDataType DataType => ElementDataType.VR;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "VR.1")]
#endif
}