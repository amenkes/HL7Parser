using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.BloodProductOrderAcknowledgementMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class BloodProductOrderAcknowledgementFactory : AbstractTriggerEventFactory<BloodProductOrderAcknowledgementFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ORB_O28:
                    return await Task.FromResult(new BloodProductOrderAcknowledgment());

                default:
                    return null;
            }
        }
    }
}