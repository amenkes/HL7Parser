using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.VaccinationRecordResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class VaccinationRecordResponseFactory : AbstractTriggerEventFactory<VaccinationRecordResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.VXR_V03:
                    return await Task.FromResult(new VaccinationRecordResponse());

                default:
                    return null;
            }
        }
    }
}