using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.QueryForVaccinationRecordMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class QueryForVaccinationRecordFactory : AbstractTriggerEventFactory<QueryForVaccinationRecordFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.VXQ_V01:
                    return await Task.FromResult(new QueryForVaccinationRecord());

                default:
                    return null;
            }
        }
    }
}