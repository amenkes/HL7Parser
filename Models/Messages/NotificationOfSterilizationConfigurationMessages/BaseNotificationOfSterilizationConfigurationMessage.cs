using HL7Data.Contracts.Messages.NotificationOfSterilizationConfigurationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.NotificationOfSterilizationConfigurationMessages
{
    public abstract class BaseNotificationOfSterilizationConfigurationMessage : BaseMessage, IBaseNotificationOfSterilizationConfigurationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.STC;
    }
}