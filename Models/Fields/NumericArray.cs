using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class NumericArray : BaseField, INumericArray
    {
        public override ElementDataType DataType => ElementDataType.NA;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "NA.1")]
#endif
}