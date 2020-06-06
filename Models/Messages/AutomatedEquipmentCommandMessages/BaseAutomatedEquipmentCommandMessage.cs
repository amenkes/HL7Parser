using HL7Data.Contracts.Messages.AutomatedEquipmentCommandMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AutomatedEquipmentCommandMessages
{
    public abstract class BaseAutomatedEquipmentCommandMessage : BaseMessage, IBaseAutomatedEquipmentCommandMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.EAC;
    }
}