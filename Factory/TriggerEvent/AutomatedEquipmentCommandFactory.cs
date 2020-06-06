using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.AutomatedEquipmentCommandMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class AutomatedEquipmentCommandFactory : AbstractTriggerEventFactory<AutomatedEquipmentCommandFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.EAC_U07:
                    return await Task.FromResult(new AutomatedEquipmentCommand());

                default:
                    return null;
            }
        }
    }
}