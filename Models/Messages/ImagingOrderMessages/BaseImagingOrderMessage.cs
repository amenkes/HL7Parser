using HL7Data.Contracts.Messages.ImagingOrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ImagingOrderMessages
{
    public abstract class BaseImagingOrderMessage : BaseMessage, IBaseImagingOrderMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OMI;
    }
}