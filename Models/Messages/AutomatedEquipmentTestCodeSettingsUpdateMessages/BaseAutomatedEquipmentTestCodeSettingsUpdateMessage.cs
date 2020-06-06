using HL7Data.Contracts.Messages.AutomatedEquipmentTestCodeSettingsUpdateMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentTestCodeSettingsUpdateMessages
{
    public abstract class BaseAutomatedEquipmentTestCodeSettingsUpdateMessage : BaseMessage, IBaseAutomatedEquipmentTestCodeSettingsUpdateMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.TCU;
    }
}