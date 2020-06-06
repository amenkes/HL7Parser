using HL7Data.Contracts.Messages.PharmacyPrescriptionOrderQueryResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyPrescriptionOrderQueryResponseMessages
{
    public class PharmacyPrescriptionOrderQueryResponse : BasePharmacyPrescriptionOrderQueryResponseMessage, IPharmacyPrescriptionOrderQueryResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ROR_ROR;
    }
}