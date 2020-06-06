using HL7Data.Contracts.Messages.DeferredQueryResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DeferredQueryResponseMessages
{
    public abstract class BaseDeferredQueryResponseMessage : BaseMessage, IBaseDeferredQueryResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DSR;
    }
}