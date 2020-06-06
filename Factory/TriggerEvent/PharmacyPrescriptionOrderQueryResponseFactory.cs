using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PharmacyPrescriptionOrderQueryResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PharmacyPrescriptionOrderQueryResponseFactory : AbstractTriggerEventFactory<PharmacyPrescriptionOrderQueryResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ROR_ROR:
                    return await Task.FromResult(new PharmacyPrescriptionOrderQueryResponse());

                default:
                    return null;
            }
        }
    }
}