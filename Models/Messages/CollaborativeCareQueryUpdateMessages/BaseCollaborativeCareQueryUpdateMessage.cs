using HL7Data.Contracts.Messages.CollaborativeCareQueryUpdateMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CollaborativeCareQueryUpdateMessages
{
    public abstract class BaseCollaborativeCareQueryUpdateMessage : BaseMessage, IBaseCollaborativeCareQueryUpdateMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.CCQ;
    }
}