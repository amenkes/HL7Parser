using HL7Data.Contracts.Messages.PatientQueryMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PatientQueryMessages
{
    public abstract class BasePatientQueryMessage : BaseMessage, IBasePatientQueryMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ADR;
    }
}