using HL7Data.Contracts.Messages.BloodProductTransfusionDispositionAcknowledgementMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductTransfusionDispositionAcknowledgementMessages
{
    public abstract class BaseBloodProductTransfusionDispositionAcknowledgementMessage : BaseMessage, IBaseBloodProductTransfusionDispositionAcknowledgementMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.BRT;
    }
}