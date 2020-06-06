using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PharmacyTreatmentGiveMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PharmacyTreatmentGiveFactory : AbstractTriggerEventFactory<PharmacyTreatmentGiveFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RGV_O15:
                    return await Task.FromResult(new PharmacyTreatmentGive());

                default:
                    return null;
            }
        }
    }
}