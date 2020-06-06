using HL7Data.Contracts.Messages.EventReplayResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.EventReplayResponseMessages
{
    public abstract class BaseEventReplayResponseMessage : BaseMessage, IBaseEventReplayResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ERP;
    }
}