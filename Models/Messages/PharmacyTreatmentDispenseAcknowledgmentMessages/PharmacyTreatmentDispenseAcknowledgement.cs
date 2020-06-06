using HL7Data.Contracts.Triggers;

namespace HL7Data.Models.Triggers
{
    public class PharmacyTreatmentDispenseAcknowledgement : BasePharmacyTreatmentDispenseAcknowledgmentMessage, IPharmacyTreatmentDispenseAcknowledgement
    {
        public override Constants.Enumerations.HL7Types.TriggerEventTypes TriggerEventType => Constants.Enumerations.HL7Types.TriggerEventTypes.RRD_O14;
    }
}