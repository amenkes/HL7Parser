using HL7Data.Contracts.Messages.PatientReferralMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PatientReferralMessages
{
    public class PatientReferral : BasePatientReferralMessage, IPatientReferral
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.REF_I12;
    }
}