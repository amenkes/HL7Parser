using HL7Data.Contracts.Messages.PharmacyTreatmentEncodedOrderInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentEncodedOrderInformationMessages
{
    public class PharmacyTreatmentEncodedOrderInformation : BasePharmacyTreatmentEncodedOrderInformationMessage, IPharmacyTreatmentEncodedOrderInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RER_RER;
    }
}