using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.BloodProductDispenseStatusAcknowledgementMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class BloodProductDispenseStatusAcknowledgementFactory : AbstractTriggerEventFactory<BloodProductDispenseStatusAcknowledgementFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.BRP_O30:
                    return await Task.FromResult(new BloodProductDispenseStatusAcknowledgment());

                default:
                    return null;
            }
        }
    }
}