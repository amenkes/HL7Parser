using HL7Data.Contracts.Messages.QueryResponseForOrderStatusMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryResponseForOrderStatusMessages
{
    public class QueryResponseForOrderStatus : BaseQueryResponseForOrderStatusMessage, IQueryResponseForOrderStatus
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OSR_Q06;
    }
}