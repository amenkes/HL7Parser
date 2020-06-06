using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PopulationLocationBasedLaboratoryOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PopulationLocationBasedLaboratoryOrderAcknowledgmentFactory : AbstractTriggerEventFactory<PopulationLocationBasedLaboratoryOrderAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.OPR_O38:
                    return await Task.FromResult(new PopulationLocationBasedLaboratoryOrderAcknowledgment());

                default:
                    return null;
            }
        }
    }
}