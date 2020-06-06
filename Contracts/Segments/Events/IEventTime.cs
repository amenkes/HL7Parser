using HL7Data.Contracts.Fields;

namespace HL7Data.Contracts.Segments.Events
{
    public interface IEventTime
    {
        IEventDateTime EventTime { get; }
    }
}