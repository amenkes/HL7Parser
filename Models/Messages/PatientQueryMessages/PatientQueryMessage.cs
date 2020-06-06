using HL7Data.Contracts.Messages.PatientQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PatientQueryMessages
{
    public class PatientQueryMessage : BasePatientQueryMessage, IPatientQueryMessage
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADR_A19;
    }
}