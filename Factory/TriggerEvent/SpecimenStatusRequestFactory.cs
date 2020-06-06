using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.SpecimenStatusRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class SpecimenStatusRequestFactory : AbstractTriggerEventFactory<SpecimenStatusRequestFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.SSR_U04:
                    return await Task.FromResult(new SpecimenStatusRequest());

                default:
                    return null;
            }
        }
    }
}