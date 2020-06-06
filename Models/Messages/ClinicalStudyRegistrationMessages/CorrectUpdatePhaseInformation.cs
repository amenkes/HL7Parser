using HL7Data.Contracts.Messages.ClinicalStudyRegistrationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ClinicalStudyRegistrationMessages
{
    public class CorrectUpdatePhaseInformation : BaseClinicalStudyRegistrationMessage, ICorrectUpdatePhaseInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.CRM_C07;
    }
}