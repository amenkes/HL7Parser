using HL7Data.Contracts.Fields;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Fields
{
    public class PractitionerInstitutionalPrivileges : BaseField, IPractitionerInstitutionalPrivileges
    {
        public override ElementDataType DataType => ElementDataType.PIP;
    }

#if TODO
    [CombineOrder(Order = 1, Name = "PIP.1")]
#endif
}