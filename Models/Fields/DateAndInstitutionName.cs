using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class DateAndInstitutionName : BaseField, IDateAndInstitutionName
    {
        public override ElementDataType DataType => ElementDataType.DIN;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "DIN.1")]
#endif
}