using HL7Data.Contracts.Messages.CollaborativeCareInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CollaborativeCareInformationMessages
{
    public abstract class BaseCollaborativeCareInformationMessage : BaseMessage, IBaseCollaborativeCareInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.CCI;
    }
}