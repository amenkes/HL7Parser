using HL7Data.Contracts.Messages.CreateSubscriptionMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CreateSubscriptionMessages
{
    public abstract class BaseCreateSubscriptionMessage : BaseMessage, IBaseCreateSubscriptionMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.QSB;
    }
}