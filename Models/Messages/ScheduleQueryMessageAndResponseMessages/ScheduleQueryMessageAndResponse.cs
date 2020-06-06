using HL7Data.Contracts.Messages.ScheduleQueryMessageAndResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ScheduleQueryMessageAndResponseMessages
{
    public class ScheduleQueryMessageAndResponse : BaseScheduleQueryMessageAndResponseMessage, IScheduleQueryMessageAndResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.SQR_S25;
    }
}