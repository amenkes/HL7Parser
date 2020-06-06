using HL7Data.Contracts.Messages.CollaborativeCareReferralUpdateMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CollaborativeCareReferralUpdateMessages
{
    public abstract class BaseCollaborativeCareReferralUpdateMessage : BaseMessage, IBaseCollaborativeCareReferralUpdateMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.CQU;
    }
}