using HL7Data.Contracts.Messages.CollaborativeCareReferralMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ContinuityOfCareRecordMessages
{
    public class ModifyCollaborativeCareReferral : BaseContinuityOfCareRecordMessage, IModifyCollaborativeCareReferral
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.CCR_I17;
    }
}