using HL7Data.Contracts.Messages.AutomatedEquipmentCommandMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentCommandMessages
{
    public class AutomatedEquipmentCommand : BaseAutomatedEquipmentCommandMessage, IAutomatedEquipmentCommand
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.EAC_U07;
    }
}