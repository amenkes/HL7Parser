using HL7Data.Contracts.Messages.PharmacyTreatmentOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentOrderAcknowledgmentMessages
{
    public class PharmacyTreatmentOrderAcknowledgement : BasePharmacyTreatmentOrderAcknowledgmentMessage, IPharmacyTreatmentOrderAcknowledgement
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORP_O10;
    }
}