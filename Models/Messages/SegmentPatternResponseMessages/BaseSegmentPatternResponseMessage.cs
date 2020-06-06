using HL7Data.Contracts.Messages.SegmentPatternResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SegmentPatternResponseMessages
{
    public abstract class BaseSegmentPatternResponseMessage : BaseMessage, IBaseSegmentPatternResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RSP;
    }
}