using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PharmacyTreatmentGiveAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PharmacyTreatmentGiveAcknowledgmentFactory : AbstractTriggerEventFactory<PharmacyTreatmentGiveAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RRG_O16:
                    return await Task.FromResult(new PharmacyTreatmentGiveAcknowledgement());

                default:
                    return null;
            }
        }
    }
}