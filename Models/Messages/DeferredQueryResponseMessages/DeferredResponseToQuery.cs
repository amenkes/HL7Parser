using HL7Data.Contracts.Messages.DeferredResponseQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DeferredQueryResponseMessages
{
    public class DeferredResponseToQuery : BaseDeferredQueryResponseMessage, IDeferredResponseToQuery
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.DSR_Q03;
    }
}