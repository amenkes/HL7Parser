using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PopulatioLocationBasedLaboratoryOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PopulatioLocationBasedLaboratoryOrderFactory : AbstractTriggerEventFactory<PopulatioLocationBasedLaboratoryOrderFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.OPL_O37:
                    return await Task.FromResult(new PopulationLocationBasedLaboratoryOrderMessage());

                default:
                    return null;
            }
        }
    }
}