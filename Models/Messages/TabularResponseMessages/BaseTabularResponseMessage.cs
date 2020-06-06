using HL7Data.Contracts.Messages.TabularResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.TabularResponseMessages
{
    public abstract class BaseTabularResponseMessage : BaseMessage, IBaseTabularResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RTB;
    }
}