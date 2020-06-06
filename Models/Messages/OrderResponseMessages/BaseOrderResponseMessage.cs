using HL7Data.Contracts.Messages.OrderResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.OrderResponseMessages
{
    public abstract class BaseOrderResponseMessage : BaseMessage, IBaseOrderResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORR;
    }
}