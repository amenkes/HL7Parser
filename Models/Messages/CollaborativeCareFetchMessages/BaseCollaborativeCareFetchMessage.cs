using HL7Data.Contracts.Messages.CollaborativeCareFetchMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CollaborativeCareFetchMessages
{
    public abstract class BaseCollaborativeCareFetchMessage : BaseMessage, IBaseCollaborativeCareFetchMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.CCF;
    }
}