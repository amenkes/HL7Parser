using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PharmacyTreatmentEncodedOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PharmacyTreatmentEncodedOrderFactory : AbstractTriggerEventFactory<PharmacyTreatmentEncodedOrderFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RDE_O11:
                    return await Task.FromResult(new PharmacyTreatmentEncodedOrder());

                case TriggerEventTypes.RDE_O25:
                    return await Task.FromResult(new PharmacyTreatmentRefillAuthorizationRequest());

                default:
                    return null;
            }
        }
    }
}