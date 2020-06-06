using HL7Data.Contracts.Messages.PatientReferralMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PatientReferralMessages
{
    public abstract class BasePatientReferralMessage : BaseMessage, IBasePatientReferralMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.REF;
    }
}