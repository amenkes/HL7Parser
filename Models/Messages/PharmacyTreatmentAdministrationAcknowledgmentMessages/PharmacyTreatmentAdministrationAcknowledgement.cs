using HL7Data.Contracts.Messages.PharmacyTreatmentAdministrationAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentAdministrationAcknowledgmentMessages
{
    public class PharmacyTreatmentAdministrationAcknowledgement : BasePharmacyTreatmentAdministrationAcknowledgmentMessage, IPharmacyTreatmentAdministrationAcknowledgement
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RRA_O18;
    }
}