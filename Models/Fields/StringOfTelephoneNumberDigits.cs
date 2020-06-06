using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class StringOfTelephoneNumberDigits : BaseField, IStringOfTelephoneNumberDigits
    {
        public override ElementDataType DataType => ElementDataType.SNM;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "SNM.1")]
#endif
}