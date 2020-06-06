using HL7Data.Contracts.Messages.EventReplayQueryMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.EventReplayQueryMessages
{
    public abstract class BaseEventReplayQueryMessage : BaseMessage, IBaseEventReplayQueryMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RQQ;
    }
}