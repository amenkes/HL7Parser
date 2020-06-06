using HL7Data.Contracts.Messages.PatientProblemMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PatientProblemMessages
{
    public abstract class BasePatientProblemMessage : BaseMessage, IBasePatientProblemMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.PPR;
    }
}