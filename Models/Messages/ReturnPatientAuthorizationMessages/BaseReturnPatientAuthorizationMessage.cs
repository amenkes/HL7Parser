using HL7Data.Contracts.Messages.ReturnPatientAuthorizationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnPatientAuthorizationMessages
{
    public abstract class BaseReturnPatientAuthorizationMessage : BaseMessage, IBaseReturnPatientAuthorizationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RPA;
    }
}