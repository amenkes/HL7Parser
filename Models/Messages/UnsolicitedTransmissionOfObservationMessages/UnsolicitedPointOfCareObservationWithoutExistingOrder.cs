using HL7Data.Contracts.Messages.UnsolicitedTransmissionOfObservationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedTransmissionOfObservationMessages
{
    public class UnsolicitedPointOfCareObservationWithoutExistingOrder : BaseUnsolicitedTransmissionOfObservationMessage, IUnsolicitedPointOfCareObservationWithoutExistingOrder
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORU_R30;
    }
}