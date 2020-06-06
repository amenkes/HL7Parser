using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PharmacyTreatmentEncodedOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PharmacyTreatmentEncodedOrderAcknowledgmentFactory : AbstractTriggerEventFactory<PharmacyTreatmentEncodedOrderAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RRE_O12:
                    return await Task.FromResult(new PharmacyTreatmentEncodedOrderAcknowledgement());

                case TriggerEventTypes.RRE_O26:
                    return await Task.FromResult(new PharmacyTreatmentRefillAuthorizationAcknowledgement());

                default:
                    return null;
            }
        }
    }
}