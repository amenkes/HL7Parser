using HL7Data.Contracts.Messages.SterilizationItemRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SterilizationItemRequestMessages
{
    public abstract class BaseSterilizationItemRequestMessage : BaseMessage, IBaseSterilizationItemRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.STI;
    }
}