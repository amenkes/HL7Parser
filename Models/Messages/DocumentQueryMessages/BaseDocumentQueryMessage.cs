using HL7Data.Contracts.Messages.DocumentQueryMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DocumentQueryMessages
{
    public abstract class BaseDocumentQueryMessage : BaseMessage, IBaseDocumentQueryMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DOC;
    }
}