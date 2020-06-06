using HL7Data.Contracts.Messages.UnsolicitedTransmissionOfObservationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedTransmissionOfObservationMessages
{
    public class UnsolicitedPreorderedPointOfCareObservation : BaseUnsolicitedTransmissionOfObservationMessage, IUnsolicitedPreorderedPointOfCareObservation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORU_R32;
    }
}