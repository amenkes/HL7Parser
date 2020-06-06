using HL7Data.Contracts.Messages.QueryForVaccinationRecordMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryForVaccinationRecordMessages
{
    public class QueryForVaccinationRecord : BaseQueryForVaccinationRecordMessage, IQueryForVaccinationRecord
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.VXQ_V01;
    }
}