using HL7Data.Contracts.Messages.AutomatedEquipmentStatusUpdateAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentStatusUpdateAcknowledgmentMessages
{
    public abstract class BaseAutomatedEquipmentStatusUpdateAcknowledgmentMessage : BaseMessage, IBaseAutomatedEquipmentStatusUpdateAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ESR;
    }
}