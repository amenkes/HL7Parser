using HL7Data.Contracts.Messages.QueryResponseForOrderStatusMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryResponseForOrderStatusMessages
{
    public abstract class BaseQueryResponseForOrderStatusMessage : BaseMessage, IBaseQueryResponseForOrderStatusMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OSR;
    }
}