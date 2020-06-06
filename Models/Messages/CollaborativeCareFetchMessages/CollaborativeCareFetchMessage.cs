using HL7Data.Contracts.Messages.CollaborativeCareFetchMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CollaborativeCareFetchMessages
{
    public class CollaborativeCareFetchMessage : BaseCollaborativeCareFetchMessage, ICollaborativeCareFetchMessage
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.CCF_I22;
    }
}