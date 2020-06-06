using HL7Data.Contracts.Messages.UnsolicitedTransmissionOfObservationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedTransmissionOfObservationMessages
{
    public class UnsolicitedTransmissionObservationSpecimen : BaseUnsolicitedTransmissionOfObservationMessage, IUnsolicitedTransmissionObservationSpecimen
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORU_R01;
    }
}