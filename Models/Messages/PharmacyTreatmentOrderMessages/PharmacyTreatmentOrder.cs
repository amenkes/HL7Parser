using HL7Data.Contracts.Messages.PharmacyTreatmentOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentOrderMessages
{
    public class PharmacyTreatmentOrder : BasePharmacyTreatmentOrderMessage, IPharmacyTreatmentOrder
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OMP_O09;
    }
}