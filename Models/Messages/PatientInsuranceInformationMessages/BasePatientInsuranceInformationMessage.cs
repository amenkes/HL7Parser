using HL7Data.Contracts.Messages.PatientInsuranceInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PatientInsuranceInformationMessages
{
    public abstract class BasePatientInsuranceInformationMessage : BaseMessage, IBasePatientInsuranceInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.PIN;
    }
}