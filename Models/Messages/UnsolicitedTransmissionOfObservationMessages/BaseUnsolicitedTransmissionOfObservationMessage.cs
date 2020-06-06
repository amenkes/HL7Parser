using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedTransmissionOfObservationMessages
{
    public class BaseUnsolicitedTransmissionOfObservationMessage : BaseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORU;
    }
}