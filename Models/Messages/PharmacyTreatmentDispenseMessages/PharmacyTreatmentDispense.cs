using HL7Data.Contracts.Messages.PharmacyTreatmentDispenseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentDispenseMessages
{
    public class PharmacyTreatmentDispense : BasePharmacyTreatmentDispenseMessage, IPharmacyTreatmentDispense
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RDS_O13;
    }
}