using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ErrorMessages
{
    public abstract class BaseErrorMessage : BaseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.Unknown;
    }
}