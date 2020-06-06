using HL7Data.Contracts.Messages.PharmacyTreatmentAdministrationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentAdministrationMessages
{
    public class BasePharmacyTreatmentAdministrationMessage : BaseMessage, IBasePharmacyTreatmentAdministrationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RAS;
    }
}