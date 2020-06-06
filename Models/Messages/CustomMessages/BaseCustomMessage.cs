using HL7Data.Contracts.Messages.CustomMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CustomMessages
{
    public abstract class BaseCustomMessage : BaseMessage, IBaseCustomMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ZZZ;
    }
}