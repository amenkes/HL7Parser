using HL7Data.Contracts.Messages.ClinicalStudyRegistrationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ClinicalStudyRegistrationMessages
{
    public class CorrectUpdateRegistrationInformation : BaseClinicalStudyRegistrationMessage, ICorrectUpdateRegistrationInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.CRM_C03;
    }
}