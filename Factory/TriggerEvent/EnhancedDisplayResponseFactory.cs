using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.EnhancedDisplayResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class EnhancedDisplayResponseFactory : AbstractTriggerEventFactory<EnhancedDisplayResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.EDR_R07:
                    return await Task.FromResult(new EnhancedDisplayResponse());

                default:
                    return null;
            }
        }
    }
}