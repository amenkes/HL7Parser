using HL7Data.Contracts.Messages.AutomatedEquipmentTestCodeSettingsRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentTestCodeSettingsRequestMessages
{
    public abstract class BaseAutomatedEquipmentTestCodeSettingsRequestMessage : BaseMessage, IBaseAutomatedEquipmentTestCodeSettingsRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.TCR;
    }
}