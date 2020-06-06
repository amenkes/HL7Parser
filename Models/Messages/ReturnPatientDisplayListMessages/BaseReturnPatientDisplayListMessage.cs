using HL7Data.Contracts.Messages.ReturnPatientDisplayListMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnPatientDisplayListMessages
{
    public abstract class BaseReturnPatientDisplayListMessage : BaseMessage, IBaseReturnPatientDisplayListMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RPL;
    }
}