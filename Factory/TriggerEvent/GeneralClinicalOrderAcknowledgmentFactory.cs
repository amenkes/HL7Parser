using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.GeneralClinicalOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class GeneralClinicalOrderAcknowledgmentFactory : AbstractTriggerEventFactory<GeneralClinicalOrderAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ORG_O20:
                    return await Task.FromResult(new GeneralClinicalOrderResponse());

                default:
                    return null;
            }
        }
    }
}