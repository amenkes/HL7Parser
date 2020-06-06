using HL7Data.Contracts.Messages.CollaborativeCareQueryUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CollaborativeCareQueryUpdateMessages
{
    public class CollaborativeCareQuery : BaseCollaborativeCareQueryUpdateMessage, ICollaborativeCareQueryUpdate
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.CCQ_I19;
    }
}