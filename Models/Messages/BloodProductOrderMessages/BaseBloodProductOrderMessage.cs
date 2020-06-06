using HL7Data.Contracts.Messages.BloodProductOrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductOrderMessages
{
    public abstract class BaseBloodProductOrderMessage : BaseMessage, IBaseBloodProductOrderMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OMB;
    }
}