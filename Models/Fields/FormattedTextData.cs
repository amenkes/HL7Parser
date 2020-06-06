using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class FormattedTextData : BaseField, IFormattedTextData
    {
        public override ElementDataType DataType => ElementDataType.FT;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "FT.1")]
#endif
}