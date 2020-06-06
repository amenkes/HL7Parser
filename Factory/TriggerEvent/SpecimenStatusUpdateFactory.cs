using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.SpecimenStatusUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class SpecimenStatusUpdateFactory : AbstractTriggerEventFactory<SpecimenStatusUpdateFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.SSU_U03:
                    return await Task.FromResult(new SpecimenStatusUpdate());

                default:
                    return null;
            }
        }
    }
}