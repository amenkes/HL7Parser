using HL7Data.Contracts.Messages.ScheduleQueryMessageAndResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ScheduleQueryMessageAndResponseMessages
{
    public abstract class BaseScheduleQueryMessageAndResponseMessage : BaseMessage, IBaseScheduleQueryMessageAndResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SQR;
    }
}