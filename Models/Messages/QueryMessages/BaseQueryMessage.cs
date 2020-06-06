using HL7Data.Contracts.Messages.QueryMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryMessages
{
    public class BaseQueryMessage : BaseMessage, IBaseQueryMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.QRY;
    }
}