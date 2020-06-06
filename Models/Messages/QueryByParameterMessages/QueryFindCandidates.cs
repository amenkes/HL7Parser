using HL7Data.Contracts.Messages.QueryByParameterMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryByParameterMessages
{
    public class QueryFindCandidates : BaseQueryByParameterMessage, IQueryFindCandidates
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.QBP_Q22;
    }
}