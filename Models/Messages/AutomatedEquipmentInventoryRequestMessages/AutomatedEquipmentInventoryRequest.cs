using HL7Data.Contracts.Messages.AutomatedEquipmentInventoryRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentInventoryRequestMessages
{
    public class AutomatedEquipmentInventoryRequest : BaseAutomatedEquipmentInventoryRequestMessage, IAutomatedEquipmentInventoryRequest
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.INR_U06;
    }
}