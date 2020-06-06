using HL7Data.Contracts.Messages.AutomatedEquipmentInventoryRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentInventoryRequestMessages
{
    public abstract class BaseAutomatedEquipmentInventoryRequestMessage : BaseMessage, IBaseAutomatedEquipmentInventoryRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.INR;
    }
}