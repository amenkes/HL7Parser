using HL7Data.Contracts.Messages.PharmacyTreatmentAdministrationInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentAdministrationInformationMessages
{
    public class PharmacyTreatmentAdministrationInformation : BasePharmacyTreatmentAdministrationInformationMessage, IPharmacyTreatmentAdministrationInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RAR_RAR;
    }
}