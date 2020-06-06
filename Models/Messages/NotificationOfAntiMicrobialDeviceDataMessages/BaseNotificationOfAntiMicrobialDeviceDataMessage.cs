using HL7Data.Contracts.Messages.NotificationOfAntiMicrobialDeviceDataMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.NotificationOfAntimicrobialDeviceDataMessages
{
    public abstract class BaseNotificationOfAntimicrobialDeviceDataMessage : BaseMessage, IBaseNotificationOfAntimicrobialDeviceDataMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SDN;
    }
}