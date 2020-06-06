using HL7Data.Contracts.Messages.UnsolicitedTransmissionOfObservationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedTransmissionOfObservationMessages
{
    public class UnsolicitedTransmissionObservationGeneral : BaseUnsolicitedTransmissionOfObservationMessage, IUnsolicitedTransmissionObservationGeneral
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORU;
    }
}