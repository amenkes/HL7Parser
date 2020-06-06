using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.DeferredQueryResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class DeferredQueryResponseFactory : AbstractTriggerEventFactory<DeferredQueryResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.DSR_Q01:
                    return await Task.FromResult(new DisplayResponseMessage());

                case TriggerEventTypes.DSR_Q03:
                    return await Task.FromResult(new DeferredResponseToQuery());

                default:
                    return null;
            }
        }
    }
}