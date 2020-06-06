using HL7Data.Contracts.Messages.DisplayBasedResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DisplayBasedResponseMessages
{
    public abstract class BaseDisplayBasedResponseMessage : BaseMessage, IBaseDisplayBasedResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RDY;
    }
}