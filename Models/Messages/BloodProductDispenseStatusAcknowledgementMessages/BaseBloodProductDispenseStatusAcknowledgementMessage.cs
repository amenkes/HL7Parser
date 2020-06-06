using HL7Data.Contracts.Messages.BloodProductDispenseStatusAcknowledgementMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductDispenseStatusAcknowledgementMessages
{
    public abstract class BaseBloodProductDispenseStatusAcknowledgementMessage : BaseMessage, IBaseBloodProductDispenseStatusAcknowledgementMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.BRP;
    }
}