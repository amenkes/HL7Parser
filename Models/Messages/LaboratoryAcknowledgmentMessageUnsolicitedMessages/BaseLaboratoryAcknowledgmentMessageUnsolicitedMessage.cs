using HL7Data.Contracts.Messages.LaboratoryAcknowledgmentMessageUnsolicitedMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.LaboratoryAcknowledgmentMessageUnsolicitedMessages
{
    public abstract class BaseLaboratoryAcknowledgmentMessageUnsolicitedMessage : BaseMessage, IBaseLaboratoryAcknowledgmentMessageUnsolicitedMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORL;
    }
}