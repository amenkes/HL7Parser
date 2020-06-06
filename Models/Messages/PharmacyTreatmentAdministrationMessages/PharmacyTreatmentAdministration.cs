using HL7Data.Contracts.Messages.PharmacyTreatmentAdministrationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentAdministrationMessages
{
    public class PharmacyTreatmentAdministration : BasePharmacyTreatmentAdministrationMessage, IPharmacyTreatmentAdministration
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RAS_O17;
    }
}