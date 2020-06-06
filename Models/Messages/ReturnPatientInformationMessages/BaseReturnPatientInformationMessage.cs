using HL7Data.Contracts.Messages.ReturnPatientInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnPatientInformationMessages
{
    public abstract class BaseReturnPatientInformationMessage : BaseMessage, IBaseReturnPatientInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RPI;
    }
}