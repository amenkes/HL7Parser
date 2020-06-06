using HL7Data.Contracts.Messages.AutomatedEquipmentInventoryUpdateMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentInventoryUpdateMessages
{
    public abstract class BaseAutomatedEquipmentInventoryUpdateMessage : BaseMessage, IBaseAutomatedEquipmentInventoryUpdateMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.INU;
    }
}