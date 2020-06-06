using HL7Data.Contracts.Messages.PharmacyTreatmentOrderAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentOrderAcknowledgmentMessages
{
    public abstract class BasePharmacyTreatmentOrderAcknowledgmentMessage : BaseMessage, IBasePharmacyTreatmentOrderAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORP;
    }
}