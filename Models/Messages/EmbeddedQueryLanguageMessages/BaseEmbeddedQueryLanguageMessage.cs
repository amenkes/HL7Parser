using HL7Data.Contracts.Messages.EmbeddedQueryLanguageMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.EmbeddedQueryLanguageMessages
{
    public abstract class BaseEmbeddedQueryLanguageMessage : BaseMessage, IBaseEmbeddedQueryLanguageMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.EQQ;
    }
}