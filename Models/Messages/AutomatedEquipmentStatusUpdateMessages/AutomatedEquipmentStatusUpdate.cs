using HL7Data.Contracts.Messages.AutomatedEquipmentStatusUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentStatusUpdateMessages
{
    public class AutomatedEquipmentStatusUpdate : BaseAutomatedEquipmentStatusUpdateMessage, IAutomatedEquipmentStatusUpdate
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ESU_U01;
    }
}