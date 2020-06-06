using HL7Data.Contracts.Messages.EventReplayResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.EventReplayResponseMessages
{
    public class EventReplayResponse : BaseEventReplayResponseMessage, IEventReplayResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ERP_R09;
    }
}