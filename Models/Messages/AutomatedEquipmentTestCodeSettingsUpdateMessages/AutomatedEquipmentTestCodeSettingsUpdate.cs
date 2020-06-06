using HL7Data.Contracts.Messages.AutomatedEquipmentTestCodeSettingsUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentTestCodeSettingsUpdateMessages
{
    public class AutomatedEquipmentTestCodeSettingsUpdate : BaseAutomatedEquipmentTestCodeSettingsUpdateMessage, IAutomatedEquipmentTestCodeSettingsUpdate
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.TCU_U10;
    }
}