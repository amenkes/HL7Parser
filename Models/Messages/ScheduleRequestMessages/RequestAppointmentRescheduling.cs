using HL7Data.Contracts.Messages.ScheduleRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ScheduleRequestMessages
{
    public class RequestAppointmentRescheduling : BaseScheduleRequestMessage, IRequestAppointmentRescheduling
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.SRM_S02;
    }
}