using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class ErrorLocation : BaseField, IErrorLocation
    {
        public override ElementDataType DataType => ElementDataType.ERL;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "ERL.1")]
#endif
}