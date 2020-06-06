using HL7Data.Contracts.Messages.CollaborativeCareMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CollaborativeCareMessages
{
    public abstract class BaseCollaborativeCareMessage : BaseMessage, IBaseCollaborativeCareMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.CCM;
    }
}