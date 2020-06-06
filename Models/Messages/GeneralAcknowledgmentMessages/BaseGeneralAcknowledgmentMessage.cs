using HL7Data.Contracts.Messages.GeneralAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.GeneralAcknowledgmentMessages
{
    public abstract class BaseGeneralAcknowledgmentMessage : BaseMessage, IBaseGeneralAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ACK;
    }
}