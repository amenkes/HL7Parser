using HL7Data.Contracts.Messages.ScheduleInformationUnsolicitedMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ScheduleInformationUnsolicitedMessages
{
    public class NotificationAppointmentDeletion : BaseScheduleInformationUnsolicitedMessage, INotificationAppointmentDeletion
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.SIU_S17;
    }
}