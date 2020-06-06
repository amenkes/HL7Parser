using HL7Data.Contracts.Messages.UnsolicitedStudyDataMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedStudyDataMessages
{
    public class PatientCompletesClinicalTrialPhase : BaseUnsolicitedStudyDataMessage, IPatientCompletesClinicalTrialPhase
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.CSU_C11;
    }
}