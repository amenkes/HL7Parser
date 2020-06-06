using HL7Data.Contracts.Messages.NotificationOfNewSterilizationLotMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.NotificationOfNewSterilizationLotMessages
{
    public abstract class BaseNotificationOfNewSterilizationLotMessage : BaseMessage, IBaseNotificationOfNewSterilizationLotMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SLN;
    }
}