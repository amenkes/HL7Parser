using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.AutomatedEquipmentLogServiceRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class AutomatedEquipmentLogServiceRequestFactory : AbstractTriggerEventFactory<AutomatedEquipmentLogServiceRequestFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.LSR_U13:
                    return await Task.FromResult(new AutomatedEquipmentLogServiceRequest());

                default:
                    return null;
            }
        }
    }
}