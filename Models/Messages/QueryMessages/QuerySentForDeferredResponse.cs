using HL7Data.Contracts.Messages.QueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryMessages
{
    public class QuerySentForDeferredResponse : BaseQueryMessage, IQuerySentForDeferredResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.QRY_Q02;
    }
}