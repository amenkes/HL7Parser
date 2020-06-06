using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class TextData : BaseField, ITextData
    {
        public override ElementDataType DataType => ElementDataType.TX;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "TX.1")]
#endif
}