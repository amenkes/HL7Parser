using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class Numeric : BaseField, INumeric
    {
        public override ElementDataType DataType => ElementDataType.NM;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "NM.1")]
#endif
}