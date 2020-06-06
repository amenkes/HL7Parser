using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.CollaborativeCareFetchMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class CollaborativeCareFetchFactory : AbstractTriggerEventFactory<CollaborativeCareFetchFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.CCF_I22:
                    return await Task.FromResult(new CollaborativeCareFetchMessage());

                default:
                    return null;
            }
        }
    }
}