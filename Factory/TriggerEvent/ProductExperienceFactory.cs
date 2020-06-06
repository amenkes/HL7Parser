using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.ProductExperienceMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class ProductExperienceFactory : AbstractTriggerEventFactory<ProductExperienceFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.PEX_P07:
                    return await Task.FromResult(new UnsolicitedInitialIndividualProductExperienceReport());

                case TriggerEventTypes.PEX_P08:
                    return await Task.FromResult(new UnsolicitedUpdateIndividualProductExperienceReport());

                default:
                    return null;
            }
        }
    }
}