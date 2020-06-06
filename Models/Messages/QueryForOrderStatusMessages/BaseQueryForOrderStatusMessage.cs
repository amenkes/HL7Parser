using HL7Data.Contracts.Messages.QueryForOrderStatusMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryForOrderStatusMessages
{
    public abstract class BaseQueryForOrderStatusMessage : BaseMessage, IBaseQueryForOrderStatusMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OSQ;
    }
}