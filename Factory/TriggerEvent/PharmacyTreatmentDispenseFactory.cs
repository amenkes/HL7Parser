using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.PharmacyTreatmentDispenseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class PharmacyTreatmentDispenseFactory : AbstractTriggerEventFactory<PharmacyTreatmentDispenseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RDS_O13:
                    return await Task.FromResult(new PharmacyTreatmentDispense());

                default:
                    return null;
            }
        }
    }
}