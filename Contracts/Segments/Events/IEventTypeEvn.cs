namespace HL7Data.Contracts.Segments.Events
{
    public interface IEventTypeEvn : IEventTime
    {
        string EventTypeCode { get; }
    }
}