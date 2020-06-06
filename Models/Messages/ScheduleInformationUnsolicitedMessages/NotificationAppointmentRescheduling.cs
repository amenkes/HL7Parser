using HL7Data.Contracts.Messages.ScheduleInformationUnsolicitedMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ScheduleInformationUnsolicitedMessages
{
    public class NotificationAppointmentRescheduling : BaseScheduleInformationUnsolicitedMessage, INotificationAppointmentRescheduling
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.SIU_S13;
    }
}