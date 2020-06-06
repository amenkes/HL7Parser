using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.LaboratoryOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class LaboratoryOrderFactory : AbstractTriggerEventFactory<LaboratoryOrderFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.OML_O21:
                    return await Task.FromResult(new LaboratoryOrder());

                case TriggerEventTypes.OML_O33:
                    return await Task.FromResult(new LaboratoryOrderForMultipleOrdersRelatedToSingleSpecimen());

                case TriggerEventTypes.OML_O35:
                    return await Task.FromResult(new LaboratoryOrderForMultipleOrdersRelatedToSingleSpecimenContainer());

                case TriggerEventTypes.OML_O39:
                    return await Task.FromResult(new SpecimenShipmentCentricLaboratoryOrder());

                default:
                    return null;
            }
        }
    }
}