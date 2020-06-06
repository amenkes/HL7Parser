using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.CollaborativeCareQueryUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class CollaborativeCareQueryFactory : AbstractTriggerEventFactory<CollaborativeCareQueryFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.CCQ_I19:
                    return await Task.FromResult(new CollaborativeCareQuery());

                default:
                    return null;
            }
        }
    }
}