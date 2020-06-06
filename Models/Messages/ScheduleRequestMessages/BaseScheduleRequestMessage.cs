using HL7Data.Contracts.Messages.ScheduleRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ScheduleRequestMessages
{
    public abstract class BaseScheduleRequestMessage : BaseMessage, IBaseScheduleRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SRM;
    }
}