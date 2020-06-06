using HL7Data.Contracts.Messages.ResponseToQueryTransmissionOfRequestedObservationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ResponseToQueryTransmissionOfRequestedObservationMessages
{
    public class ResponseToQueryTransmissionOfRequestedObservation : BaseResponseToQueryTransmissionOfRequestedObservationMessage, IResponseToQueryTransmissionOfRequestedObservation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORF_R04;
    }
}