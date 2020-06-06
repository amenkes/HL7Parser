using HL7Data.Contracts.Messages.ImagingOrderAcknowledgementMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ImagingOrderAcknowledgementMessages
{
    public abstract class BaseImagingOrderAcknowledgementMessage : BaseMessage, IBaseImagingOrderAcknowledgementMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORI;
    }
}