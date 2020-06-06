using HL7Data.Contracts.Messages.PopulatioLocationBasedLaboratoryOrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PopulatioLocationBasedLaboratoryOrderMessages
{
    public abstract class BasePopulatioLocationBasedLaboratoryOrderMessage : BaseMessage, IBasePopulatioLocationBasedLaboratoryOrderMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OPL;
    }
}