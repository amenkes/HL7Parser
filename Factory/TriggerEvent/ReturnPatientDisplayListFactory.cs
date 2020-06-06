using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ReturnPatientDisplayListMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ReturnPatientDisplayListFactory : AbstractTriggerEventFactory<ReturnPatientDisplayListFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RPL_I02:
                    return await Task.FromResult(new ReturnPatientDisplayList());

                default:
                    return null;
            }
        }
    }
}