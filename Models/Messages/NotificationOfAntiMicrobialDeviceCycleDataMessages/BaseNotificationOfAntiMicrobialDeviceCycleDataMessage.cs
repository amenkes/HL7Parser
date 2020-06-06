using HL7Data.Contracts.Messages.NotificationOfAntiMicrobialDeviceCycleDataMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.NotificationOfAntimicrobialDeviceCycleDataMessages
{
    public abstract class BaseNotificationOfAntimicrobialDeviceCycleDataMessage : BaseMessage, IBaseNotificationOfAntimicrobialDeviceCycleDataMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SCN;
    }
}