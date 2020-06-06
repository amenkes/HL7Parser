using HL7Data.Contracts.Messages.AutomatedEquipmentResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentResponseMessages
{
    public class AutomatedEquipmentResponse : BaseAutomatedEquipmentResponseMessage, IAutomatedEquipmentResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.EAR_U08;
    }
}