using HL7Data.Contracts.Messages.ClinicalStudyRegistrationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ClinicalStudyRegistrationMessages
{
    public abstract class BaseClinicalStudyRegistrationMessage : BaseMessage, IBaseClinicalStudyRegistrationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.CRM;
    }
}