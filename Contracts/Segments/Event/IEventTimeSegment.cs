using HL7Data.Contracts.Base;
using HL7Data.Contracts.Fields;

namespace HL7Data.Contracts.Segments.Event
{
    public interface IEventTimeSegment : ISegment
    {
        IEventDateTime EventTime { get; set; }
    }
}