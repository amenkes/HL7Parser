using HL7Data.Contracts.Messages.AutomatedEquipmentTestCodeSettingsRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentTestCodeSettingsRequestMessages
{
    public class AutomatedEquipmentTestCodeSettingsRequest : BaseAutomatedEquipmentTestCodeSettingsRequestMessage, IAutomatedEquipmentTestCodeSettingsRequest
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.TCR_U11;
    }
}