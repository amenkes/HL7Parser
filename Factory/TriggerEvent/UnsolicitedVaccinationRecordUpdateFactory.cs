using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.UnsolicitedVaccinationRecordUpdateMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class UnsolicitedVaccinationRecordUpdateFactory : AbstractTriggerEventFactory<UnsolicitedVaccinationRecordUpdateFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.VXU_V04:
                    return await Task.FromResult(new UnsolicitedVaccinationRecordUpdate());

                default:
                    return null;
            }
        }
    }
}