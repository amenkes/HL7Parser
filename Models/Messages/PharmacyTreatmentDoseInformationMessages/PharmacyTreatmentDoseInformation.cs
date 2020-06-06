using HL7Data.Contracts.Messages.PharmacyTreatmentDoseInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentDoseInformationMessages
{
    public class PharmacyTreatmentDoseInformation : BasePharmacyTreatmentDoseInformationMessage, IPharmacyTreatmentDoseInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RGR_RGR;
    }
}