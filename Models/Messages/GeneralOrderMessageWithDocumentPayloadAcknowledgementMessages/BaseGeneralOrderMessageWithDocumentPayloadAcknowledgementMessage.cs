using HL7Data.Contracts.Messages.GeneralOrderMessageWithDocumentPayloadAcknowledgementMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.GeneralOrderMessageWithDocumentPayloadAcknowledgementMessages
{
    public abstract class BaseGeneralOrderMessageWithDocumentPayloadAcknowledgementMessage : BaseMessage, IBaseGeneralOrderMessageWithDocumentPayloadAcknowledgementMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORX;
    }
}