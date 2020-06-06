using HL7Data.Contracts.Messages.SegmentPatternResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SegmentPatternResponseMessages
{
    public class SegmentPatternResponse : BaseSegmentPatternResponseMessage, ISegmentPatternResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RSP_Z90;
    }
}