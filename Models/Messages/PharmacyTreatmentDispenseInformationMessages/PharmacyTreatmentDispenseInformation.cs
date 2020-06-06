using HL7Data.Contracts.Triggers;

namespace HL7Data.Models.Triggers
{
    public class PharmacyTreatmentDispenseInformation : BasePharmacyTreatmentDispenseInformationMessage, IPharmacyTreatmentDispenseInformation
    {
        public override Constants.Enumerations.HL7Types.TriggerEventTypes TriggerEventType => Constants.Enumerations.HL7Types.TriggerEventTypes.RDR_RDR;
    }
}