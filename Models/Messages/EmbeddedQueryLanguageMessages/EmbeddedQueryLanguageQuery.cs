using HL7Data.Contracts.Messages.EmbeddedQueryLanguageMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.EmbeddedQueryLanguageMessages
{
    public class EmbeddedQueryLanguageQuery : BaseEmbeddedQueryLanguageMessage, IEmbeddedQueryLanguageQuery
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.EQQ_Q04;
    }
}