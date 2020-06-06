using HL7Data.Contracts.Messages.ScheduledRequestResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ScheduledRequestResponseMessages
{
    public class ScheduledRequestResponse : BaseScheduledRequestResponseMessage, IScheduledRequestResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.SRR_S01;
    }
}