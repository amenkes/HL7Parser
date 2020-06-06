using HL7Data.Contracts.Messages.AutomatedEquipmentNotificationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentNotificationMessages
{
    public abstract class BaseAutomatedEquipmentNotificationMessage : BaseMessage, IBaseAutomatedEquipmentNotificationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.EAN;
    }
}