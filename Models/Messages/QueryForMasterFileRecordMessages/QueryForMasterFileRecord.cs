using HL7Data.Contracts.Messages.QueryForMasterFileRecordMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryForMasterFileRecordMessages
{
    public class QueryForMasterFileRecord : BaseQueryForMasterFileRecordMessage, IQueryForMasterFileRecord
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.MFQ_M01;
    }
}