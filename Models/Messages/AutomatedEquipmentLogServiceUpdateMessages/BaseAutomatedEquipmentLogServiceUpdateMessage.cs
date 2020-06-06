using HL7Data.Contracts.Messages.AutomatedEquipmentLogServiceUpdateMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentLogServiceUpdateMessages
{
    public abstract class BaseAutomatedEquipmentLogServiceUpdateMessage : BaseMessage, IBaseAutomatedEquipmentLogServiceUpdateMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.LSU;
    }
}