using HL7Data.Contracts.Messages.CollaborativeCareReferralMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CollaborativeCareReferralMessages
{
    public abstract class BaseCollaborativeCareReferralMessage : BaseMessage, IBaseCollaborativeCareReferralMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.CCU;
    }
}