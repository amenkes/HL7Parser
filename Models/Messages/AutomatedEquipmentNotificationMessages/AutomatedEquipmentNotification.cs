using HL7Data.Contracts.Messages.AutomatedEquipmentNotificationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentNotificationMessages
{
    public class AutomatedEquipmentNotification : BaseAutomatedEquipmentNotificationMessage, IAutomatedEquipmentNotification
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.EAN_U09;
    }
}