using HL7Data.Contracts.Messages.PharmacyTreatmentEncodedOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentEncodedOrderMessages
{
    public class PharmacyTreatmentRefillAuthorizationRequest : BasePharmacyTreatmentEncodedOrderMessage, IPharmacyTreatmentRefillAuthorizationRequest
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RDE_O25;
    }
}