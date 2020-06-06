using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class PractitionerLicenseOrOtherIdNumber : BaseField, IPractitionerLicenseOrOtherIdNumber
    {
        public override ElementDataType DataType => ElementDataType.PLN;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "PLN.1")]
#endif
}