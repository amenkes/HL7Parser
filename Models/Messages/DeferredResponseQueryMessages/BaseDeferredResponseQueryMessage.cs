using HL7Data.Contracts.Messages.DeferredResponseQueryMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DeferredResponseQueryMessages
{
    public abstract class BaseDeferredResponseQueryMessage : BaseMessage, IBaseDeferredResponseQueryMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.QCK;
    }
}