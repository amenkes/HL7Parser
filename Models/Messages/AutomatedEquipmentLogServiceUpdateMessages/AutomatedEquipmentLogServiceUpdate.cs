using HL7Data.Contracts.Messages.AutomatedEquipmentLogServiceUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentLogServiceUpdateMessages
{
    public class AutomatedEquipmentLogServiceUpdate : BaseAutomatedEquipmentLogServiceUpdateMessage, IAutomatedEquipmentLogServiceUpdate
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.LSU_U12;
    }
}