using HL7Data.Contracts.Messages.CollaborativeCareMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CollaborativeCareMessages
{
    public class CollaborativeCareMessage : BaseCollaborativeCareMessage, ICollaborativeCareMessage
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.CCM_I21;
    }
}