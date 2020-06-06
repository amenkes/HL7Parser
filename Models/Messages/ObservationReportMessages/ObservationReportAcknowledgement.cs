using HL7Data.Contracts.Messages.ObservationReportMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ObservationReportMessages
{
    public class ObservationReportAcknowledgement : BaseObservationReportMessage, IObservationReportAcknowledgement
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORA_R33;
    }
}