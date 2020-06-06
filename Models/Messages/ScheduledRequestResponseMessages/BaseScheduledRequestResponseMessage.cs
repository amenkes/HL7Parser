using HL7Data.Contracts.Messages.ScheduledRequestResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ScheduledRequestResponseMessages
{
    public abstract class BaseScheduledRequestResponseMessage : BaseMessage, IBaseScheduledRequestResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SRR;
    }
}