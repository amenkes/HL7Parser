using HL7Data.Contracts.Messages.RequestPatientInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.RequestPatientInformationMessages
{
    public abstract class BaseRequestPatientInformationMessage : BaseMessage, IBaseRequestPatientInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RQI;
    }
}