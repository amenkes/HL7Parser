using HL7Data.Contracts.Messages.CollaborativeCareReferralMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CollaborativeCareReferralMessages
{
    public class CollaborativeCareUpdate : BaseCollaborativeCareReferralMessage, ICollaborativeCareUpdate
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.CCU_I20;
    }
}