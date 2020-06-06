using HL7Data.Contracts.Messages.PharmacyTreatmentGiveAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentGiveAcknowledgmentMessages
{
    public abstract class BasePharmacyTreatmentGiveAcknowledgmentMessage : BaseMessage, IBasePharmacyTreatmentGiveAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RRG;
    }
}