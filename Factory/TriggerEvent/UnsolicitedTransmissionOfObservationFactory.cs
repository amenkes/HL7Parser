using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.UnsolicitedTransmissionOfObservationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class UnsolicitedTransmissionOfObservationFactory : AbstractTriggerEventFactory<UnsolicitedTransmissionOfObservationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ORU:
                    return await Task.FromResult(new UnsolicitedTransmissionObservationGeneral());

                case TriggerEventTypes.ORU_R01:
                    return await Task.FromResult(new UnsolicitedTransmissionObservationSpecimen());

                case TriggerEventTypes.ORU_R03:
                    return await Task.FromResult(new DisplayOrientedResultsQueyrUnsolicitedUpdate());

                case TriggerEventTypes.ORU_R30:
                    return await Task.FromResult(new UnsolicitedPointOfCareObservationWithoutExistingOrder());

                case TriggerEventTypes.ORU_R31:
                    return await Task.FromResult(new UnsolicitedNewPointOfCareObservationSearchForOrder());

                case TriggerEventTypes.ORU_R32:
                    return await Task.FromResult(new UnsolicitedPreorderedPointOfCareObservation());

                default:
                    return null;
            }
        }
    }
}