using HL7Data.Contracts.Messages.VaccinationRecordResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.VaccinationRecordResponseMessages
{
    public class VaccinationRecordResponse : BaseVaccinationRecordResponseMessage, IVaccinationRecordResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.VXR_V03;
    }
}