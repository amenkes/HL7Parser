using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.NotificationOfSterilizationConfigurationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class NotificationOfSterilizationConfigurationFactory : AbstractTriggerEventFactory<NotificationOfSterilizationConfigurationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.STC_S33:
                    return await Task.FromResult(new NotificationOfSterilizationConfiguration());

                default:
                    return null;
            }
        }
    }
}