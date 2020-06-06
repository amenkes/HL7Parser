using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.UnsolicitedDisplayUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class UnsolicitedDisplayUpdateFactory : AbstractTriggerEventFactory<UnsolicitedDisplayUpdateFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.UDM_Q05:
                    return await Task.FromResult(new UnsolicitedDisplayUpdateMessage());

                default:
                    return null;
            }
        }
    }
}