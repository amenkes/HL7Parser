using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.EventReplayQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class EventReplayQueryFactory : AbstractTriggerEventFactory<EventReplayQueryFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RQQ_Q09:
                    return await Task.FromResult(new EventReplayQuery());

                default:
                    return null;
            }
        }
    }
}