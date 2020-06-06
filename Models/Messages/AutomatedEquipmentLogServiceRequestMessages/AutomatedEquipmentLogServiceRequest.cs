using HL7Data.Contracts.Messages.AutomatedEquipmentLogServiceRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentLogServiceRequestMessages
{
    public class AutomatedEquipmentLogServiceRequest : BaseAutomatedEquipmentLogServiceRequestMessage, IAutomatedEquipmentLogServiceRequest
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.LSR_U13;
    }
}