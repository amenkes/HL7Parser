using HL7Data.Contracts.Messages.PharmacyTreatmentEncodedOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentEncodedOrderAcknowledgmentMessages
{
    public class PharmacyTreatmentRefillAuthorizationAcknowledgement : BasePharmacyTreatmentEncodedOrderAcknowledgmentMessage, IPharmacyTreatmentRefillAuthorizationAcknowledgement
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RRE_O26;
    }
}