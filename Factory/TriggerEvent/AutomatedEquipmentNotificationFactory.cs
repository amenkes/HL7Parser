using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.AutomatedEquipmentNotificationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class AutomatedEquipmentNotificationFactory : AbstractTriggerEventFactory<AutomatedEquipmentNotificationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.EAN_U09:
                    return await Task.FromResult(new AutomatedEquipmentNotification());

                default:
                    return null;
            }
        }
    }
}