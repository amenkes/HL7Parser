using HL7Data.Contracts.Messages.NotificationOfSterilizationConfigurationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.NotificationOfSterilizationConfigurationMessages
{
    public class NotificationOfSterilizationConfiguration : BaseNotificationOfSterilizationConfigurationMessage, INotificationOfSterilizationConfiguration
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.STC_S33;
    }
}