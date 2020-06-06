using HL7Data.Contracts.Messages.PatientGoalMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PatientGoalMessages
{
    public abstract class BasePatientGoalMessage : BaseMessage, IBasePatientGoalMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.PGL;
    }
}