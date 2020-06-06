using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PharmacyTreatmentAdministrationInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PharmacyTreatmentAdministrationInformationFactory : AbstractTriggerEventFactory<PharmacyTreatmentAdministrationInformationFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RAR_RAR:
                    return await Task.FromResult(new PharmacyTreatmentAdministrationInformation());

                default:
                    return null;
            }
        }
    }
}