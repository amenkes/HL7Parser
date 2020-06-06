using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.CreateSubscriptionMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class CreateSubscriptionFactory : AbstractTriggerEventFactory<CreateSubscriptionFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.QSB_Q16:
                    return await Task.FromResult(new CreateSubscription());

                case TriggerEventTypes.QSB_Z83:
                    return await Task.FromResult(new OruSubscription());

                default:
                    return null;
            }
        }
    }
}