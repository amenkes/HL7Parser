using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PharmacyTreatmentEncodedOrderInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PharmacyTreatmentEncodedOrderInformationFactory : AbstractTriggerEventFactory<PharmacyTreatmentEncodedOrderInformationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RER_RER:
                    return await Task.FromResult(new PharmacyTreatmentEncodedOrderInformation());

                default:
                    return null;
            }
        }
    }
}