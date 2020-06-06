using HL7Data.Contracts.Messages.AutomatedEquipmentResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentResponseMessages
{
    public abstract class BaseAutomatedEquipmentResponseMessage : BaseMessage, IBaseAutomatedEquipmentResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.EAR;
    }
}