using HL7Data.Contracts.Messages.DietaryOrderAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DietaryOrderAcknowledgmentMessages
{
    public abstract class BaseDietaryOrderAcknowledgmentMessage : BaseMessage, IBaseDietaryOrderAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORD;
    }
}