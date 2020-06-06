using HL7Data.Contracts.Messages.PharmacyTreatmentGiveAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentGiveAcknowledgmentMessages
{
    public class PharmacyTreatmentGiveAcknowledgement : BasePharmacyTreatmentGiveAcknowledgmentMessage, IPharmacyTreatmentGiveAcknowledgement
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RRG_O16;
    }
}