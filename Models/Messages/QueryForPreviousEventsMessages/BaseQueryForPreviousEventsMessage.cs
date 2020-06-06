using HL7Data.Contracts.Messages.QueryForPreviousEventsMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryForPreviousEventsMessages
{
    public abstract class BaseQueryForPreviousEventsMessage : BaseMessage, IBaseQueryForPreviousEventsMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.QVR;
    }
}