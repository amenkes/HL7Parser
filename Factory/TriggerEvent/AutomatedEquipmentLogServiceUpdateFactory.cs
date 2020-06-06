using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.AutomatedEquipmentLogServiceUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class AutomatedEquipmentLogServiceUpdateFactory : AbstractTriggerEventFactory<AutomatedEquipmentLogServiceUpdateFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.LSU_U12:
                    return await Task.FromResult(new AutomatedEquipmentLogServiceUpdate());

                default:
                    return null;
            }
        }
    }
}