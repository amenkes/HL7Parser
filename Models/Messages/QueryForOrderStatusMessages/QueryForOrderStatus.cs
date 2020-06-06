using HL7Data.Contracts.Messages.QueryForOrderStatusMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryForOrderStatusMessages
{
    public class QueryForOrderStatus : BaseQueryForOrderStatusMessage, IQueryForOrderStatus
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OSQ_Q06;
    }
}