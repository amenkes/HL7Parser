using HL7Data.Contracts.Messages.DeferredQueryResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DeferredResponseQueryMessages
{
    public class DeferredQuery : BaseDeferredResponseQueryMessage, IDeferredQuery
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.QCK_Q02;
    }
}