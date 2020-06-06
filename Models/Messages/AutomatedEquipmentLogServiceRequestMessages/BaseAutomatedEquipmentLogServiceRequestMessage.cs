using HL7Data.Contracts.Messages.AutomatedEquipmentLogServiceRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentLogServiceRequestMessages
{
    public abstract class BaseAutomatedEquipmentLogServiceRequestMessage : BaseMessage, IBaseAutomatedEquipmentLogServiceRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.LSR;
    }
}