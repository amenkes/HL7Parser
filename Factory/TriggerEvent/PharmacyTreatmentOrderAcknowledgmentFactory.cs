using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PharmacyTreatmentOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PharmacyTreatmentOrderAcknowledgmentFactory : AbstractTriggerEventFactory<PharmacyTreatmentOrderAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ORP_O10:
                    return await Task.FromResult(new PharmacyTreatmentOrderAcknowledgement());

                default:
                    return null;
            }
        }
    }
}