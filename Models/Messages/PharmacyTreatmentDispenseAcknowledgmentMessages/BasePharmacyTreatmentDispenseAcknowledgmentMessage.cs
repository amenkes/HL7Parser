using HL7Data.Contracts.Messages.PharmacyTreatmentDispenseAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentDispenseAcknowledgmentMessages
{
    public abstract class BasePharmacyTreatmentDispenseAcknowledgmentMessage : BaseMessage, IBasePharmacyTreatmentDispenseAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RRD;
    }
}