using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.CollaborativeCareMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class CollaborativeCareFactory : AbstractTriggerEventFactory<CollaborativeCareFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.CCM_I21:
                    return await Task.FromResult(new CollaborativeCareMessage());

                default:
                    return null;
            }
        }
    }
}