using HL7Data.Contracts.Messages.PharmacyTreatmentEncodedOrderAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentEncodedOrderAcknowledgmentMessages
{
    public abstract class BasePharmacyTreatmentEncodedOrderAcknowledgmentMessage : BaseMessage, IBasePharmacyTreatmentEncodedOrderAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RRE;
    }
}