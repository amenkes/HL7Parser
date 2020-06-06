using HL7Data.Contracts.Messages.DocumentQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DocumentQueryMessages
{
    public class DocumentResponse : BaseDocumentQueryMessage, IDocumentResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.DOC_T12;
    }
}