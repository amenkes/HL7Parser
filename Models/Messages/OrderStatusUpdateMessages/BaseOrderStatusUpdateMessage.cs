using HL7Data.Contracts.Messages.OrderStatusUpdateMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.OrderStatusUpdateMessages
{
    public abstract class BaseOrderStatusUpdateMessage : BaseMessage, IBaseOrderStatusUpdateMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OSU;
    }
}