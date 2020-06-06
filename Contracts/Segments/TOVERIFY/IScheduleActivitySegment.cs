using HL7Data.Contracts.Segments.Event;

namespace HL7Data.Contracts.Segments.TOVERIFY
{
    public interface IScheduleActivitySegment : IEventTimeSegment
    {
        string PlacerAppointmentId { get; }
        string EventReasonId { get; }
        string AppointmentReason { get; }
        string AppointmentDuration { get; }
        string AppointmentDurationUnits { get; }
        string AppointmentStart { get; }
        string AppointmentEnd { get; }
        string FillerContactPerson { get; }
        string EnteredByPerson { get; }
        string FillerStatusCode { get; }
    }
}