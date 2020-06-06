using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.LaboratoryAcknowledgmentMessageUnsolicitedMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class LaboratoryAcknowledgmentMessageUnsolicitedFactory : AbstractTriggerEventFactory<LaboratoryAcknowledgmentMessageUnsolicitedFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ORL_O22:
                    return await Task.FromResult(new GeneralLaboratoryOrderResponseMessageToAnyOml());

                case TriggerEventTypes.ORL_O34:
                    return await Task.FromResult(new LaboratoryOrderResponseToMultipleOrderRelatedToSingleSpecimen());

                case TriggerEventTypes.ORL_O36:
                    return await Task.FromResult(new LaboratoryOrderResponseMessageToSingleContainerOfSpecimenOml());

                case TriggerEventTypes.ORL_O40:
                    return await Task.FromResult(new SpecimenShipmentCentricLaboratoryOrderAcknowledgmentMessage());

                default:
                    return null;
            }
        }
    }
}