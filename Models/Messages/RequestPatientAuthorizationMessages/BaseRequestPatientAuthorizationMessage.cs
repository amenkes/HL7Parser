using HL7Data.Contracts.Messages.RequestPatientAuthorizationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.RequestPatientAuthorizationMessages
{
    public abstract class BaseRequestPatientAuthorizationMessage : BaseMessage, IBaseRequestPatientAuthorizationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RQA;
    }
}