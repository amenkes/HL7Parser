using HL7Data.Contracts.Messages.ReturnPatientListMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnPatientListMessages
{
    public abstract class BaseReturnPatientListMessage : BaseMessage, IBaseReturnPatientListMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RPR;
    }
}