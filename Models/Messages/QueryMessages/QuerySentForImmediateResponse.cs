using HL7Data.Contracts.Messages.QueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryMessages
{
    public class QuerySentForImmediateResponse : BaseQueryMessage, IQuerySentForImmediateResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.QRY_Q01;
    }
}