using HL7Data.Contracts.Messages.EventReplayQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.EventReplayQueryMessages
{
    public class EventReplayQuery : BaseEventReplayQueryMessage, IEventReplayQuery
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RQQ_Q09;
    }
}