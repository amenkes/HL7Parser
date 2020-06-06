using HL7Data.Contracts.Messages.AutomatedEquipmentInventoryUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentInventoryUpdateMessages
{
    public class AutomatedEquipmentInventoryUpdate : BaseAutomatedEquipmentInventoryUpdateMessage, IAutomatedEquipmentInventoryUpdate
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.INU_U05;
    }
}