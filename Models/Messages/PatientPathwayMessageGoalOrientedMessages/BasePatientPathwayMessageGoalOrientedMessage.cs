using HL7Data.Contracts.Messages.PatientPathwayMessageGoalOrientedMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PatientPathwayMessageGoalOrientedMessages
{
    public abstract class BasePatientPathwayMessageGoalOrientedMessage : BaseMessage, IBasePatientPathwayMessageGoalOrientedMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.PPG;
    }
}