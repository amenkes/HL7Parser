using HL7Data.Contracts.Messages.UnsolicitedStudyDataMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedStudyDataMessages
{
    public class UpdatePatientOrderResultInformation : BaseUnsolicitedStudyDataMessage, IUpdatePatientOrderResultInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.CSU_C12;
    }
}