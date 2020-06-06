using HL7Data.Contracts.Messages.RequestPatientClinicalInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.RequestPatientClinicalInformationMessages
{
    public abstract class BaseRequestPatientClinicalInformationMessage : BaseMessage, IBaseRequestPatientClinicalInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RQC;
    }
}