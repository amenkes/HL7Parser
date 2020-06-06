using HL7Data.Contracts.Messages.PharmacyTreatmentAdministrationAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentAdministrationAcknowledgmentMessages
{
    public abstract class BasePharmacyTreatmentAdministrationAcknowledgmentMessage : BaseMessage, IBasePharmacyTreatmentAdministrationAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RRA;
    }
}