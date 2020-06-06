using HL7Data.Contracts.Segments.Event;

namespace HL7Data.Contracts.Segments.Application
{
    public interface IEventTypeEvnSegment : IEventTimeSegment
    {
        string EventTypeCode { get; set; }
    }
}