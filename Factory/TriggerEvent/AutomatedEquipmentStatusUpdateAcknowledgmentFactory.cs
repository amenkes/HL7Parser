using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.AutomatedEquipmentStatusUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class AutomatedEquipmentStatusUpdateAcknowledgmentFactory : AbstractTriggerEventFactory<AutomatedEquipmentStatusUpdateAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ESR_U02:
                    return await Task.FromResult(new AutomatedEquipmentStatusRequest());

                default:
                    return null;
            }
        }
    }
}