using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PharmacyTreatmentAdministrationAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PharmacyTreatmentAdministrationAcknowledgmentFactory : AbstractTriggerEventFactory<PharmacyTreatmentAdministrationAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RRA_O18:
                    return await Task.FromResult(new PharmacyTreatmentAdministrationAcknowledgement());

                default:
                    return null;
            }
        }
    }
}