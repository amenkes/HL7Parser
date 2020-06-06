using HL7Data.Contracts.Messages.PatientPathwayMessageProblemOrientedMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PatientPathwayMessageProblemOrientedMessages
{
    public abstract class BasePatientPathwayMessageProblemOrientedMessage : BaseMessage, IBasePatientPathwayMessageProblemOrientedMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.PPP;
    }
}