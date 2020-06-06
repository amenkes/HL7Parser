using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.BloodProductTransfusionDispositionAcknowledgementMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class BloodProductTransfusionDispositionAcknowledgementFactory : AbstractTriggerEventFactory<BloodProductTransfusionDispositionAcknowledgementFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.BRT_O32:
                    return await Task.FromResult(new BloodProductTransfusionDispositionAcknowledgment());

                default:
                    return null;
            }
        }
    }
}