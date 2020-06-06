using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.AutomatedEquipmentResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class AutomatedEquipmentResponseFactory : AbstractTriggerEventFactory<AutomatedEquipmentResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.EAR_U08:
                    return await Task.FromResult(new AutomatedEquipmentResponse());

                default:
                    return null;
            }
        }
    }
}