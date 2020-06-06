using HL7Data.Contracts.Messages.BloodProductOrderAcknowledgementMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductOrderAcknowledgementMessages
{
    public abstract class BaseBloodProductOrderAcknowledgementMessage : BaseMessage, IBaseBloodProductOrderAcknowledgementMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORB;
    }
}