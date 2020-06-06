using HL7Data.Contracts.Messages.PersonnelMasterMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PersonnelMasterMessages
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
    public class RevokeCertificatePermission : BasePersonnelMasterMessage, IRevokeCertificatePermission
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.PMU_B08;
    }
}