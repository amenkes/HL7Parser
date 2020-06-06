using HL7Data.Contracts.Messages.UnsolicitedStudyDataMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedStudyDataMessages
{
    public class PatientCompletesClinicalTrial : BaseUnsolicitedStudyDataMessage, IPatientCompletesClinicalTrial
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.CSU_C10;
    }
}