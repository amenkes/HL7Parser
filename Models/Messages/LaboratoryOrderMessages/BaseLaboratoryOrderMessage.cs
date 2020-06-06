using HL7Data.Contracts.Messages.LaboratoryOrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.LaboratoryOrderMessages
{
    public abstract class BaseLaboratoryOrderMessage : BaseMessage, IBaseLaboratoryOrderMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OML;
    }
}