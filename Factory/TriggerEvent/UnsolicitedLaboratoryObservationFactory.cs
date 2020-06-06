using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.UnsolicitedLaboratoryObservationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class UnsolicitedLaboratoryObservationFactory : AbstractTriggerEventFactory<UnsolicitedLaboratoryObservationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.OUL_R21:
                    return await Task.FromResult(new UnsolicitedLaboratoryObservation());

                case TriggerEventTypes.OUL_R22:
                    return await Task.FromResult(new UnsolicitedSpecimenOrientedObservation());

                case TriggerEventTypes.OUL_R23:
                    return await Task.FromResult(new UnsolicitedSpecimenContainerOrientedObservation());

                case TriggerEventTypes.OUL_R24:
                    return await Task.FromResult(new UnsolicitedOrderOrientedObservation());

                default:
                    return null;
            }
        }
    }
}