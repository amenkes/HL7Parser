using HL7Data.Contracts.Messages.CancelSubscriptionAcknowledgeMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CancelSubscriptionAcknowledgeMessages
{
    public abstract class BaseCancelSubscriptionAcknowledgeMessage : BaseMessage, IBaseCancelSubscriptionAcknowledgeMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.QSX;
    }
}