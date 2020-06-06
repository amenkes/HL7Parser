using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.SterilizationItemRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class SterilizationItemRequestFactory : AbstractTriggerEventFactory<SterilizationItemRequestFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.STI_S30:
                    return await Task.FromResult(new SterilizationItemRequest());

                default:
                    return null;
            }
        }
    }
}