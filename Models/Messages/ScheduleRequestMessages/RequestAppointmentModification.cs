using HL7Data.Contracts.Messages.ScheduleRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ScheduleRequestMessages
{
    public class RequestAppointmentModification : BaseScheduleRequestMessage, IRequestAppointmentModification
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.SRM_S03;
    }
}