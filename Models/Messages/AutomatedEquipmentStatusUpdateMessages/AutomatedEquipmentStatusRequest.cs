using HL7Data.Contracts.Messages.AutomatedEquipmentStatusRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentStatusUpdateMessages
{
    public class AutomatedEquipmentStatusRequest : BaseAutomatedEquipmentStatusUpdateMessage, IAutomatedEquipmentStatusRequest
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ESR_U02;
    }
}