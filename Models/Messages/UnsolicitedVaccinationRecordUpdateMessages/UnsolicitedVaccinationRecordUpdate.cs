using HL7Data.Contracts.Messages.UnsolicitedVaccinationRecordUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedVaccinationRecordUpdateMessages
{
    public class UnsolicitedVaccinationRecordUpdate : BaseUnsolicitedVaccinationRecordUpdateMessage, IUnsolicitedVaccinationRecordUpdate
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.VXU_V04;
    }
}