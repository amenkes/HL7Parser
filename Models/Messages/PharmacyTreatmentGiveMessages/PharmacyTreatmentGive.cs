using HL7Data.Contracts.Messages.PharmacyTreatmentGiveMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentGiveMessages
{
    public class PharmacyTreatmentGive : BasePharmacyTreatmentGiveMessage, IPharmacyTreatmentGive
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RGV_O15;
    }
}