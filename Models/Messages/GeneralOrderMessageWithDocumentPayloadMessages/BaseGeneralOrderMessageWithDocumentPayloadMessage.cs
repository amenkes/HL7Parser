using HL7Data.Contracts.Messages.GeneralOrderMessageWithDocumentPayloadMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.GeneralOrderMessageWithDocumentPayloadMessages
{
    public abstract class BaseGeneralOrderMessageWithDocumentPayloadMessage : BaseMessage, IBaseGeneralOrderMessageWithDocumentPayloadMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OMQ;
    }
}