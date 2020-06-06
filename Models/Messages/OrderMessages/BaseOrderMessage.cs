using HL7Data.Contracts.Messages.OrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.OrderMessages
{
    public class BaseOrderMessage : BaseMessage, IBaseOrderMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORM;
    }
}