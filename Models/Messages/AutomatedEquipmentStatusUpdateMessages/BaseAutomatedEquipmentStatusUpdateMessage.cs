using HL7Data.Contracts.Messages.AutomatedEquipmentStatusUpdateMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentStatusUpdateMessages
{
    public abstract class BaseAutomatedEquipmentStatusUpdateMessage : BaseMessage, IBaseAutomatedEquipmentStatusUpdateMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ESU;
    }
}