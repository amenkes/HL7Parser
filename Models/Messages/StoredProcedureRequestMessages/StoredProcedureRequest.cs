using HL7Data.Contracts.Messages.StoredProcedureRequestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.StoredProcedureRequestMessages
{
    public class StoredProcedureRequest : BaseStoredProcedureRequestMessage, IStoredProcedureRequest
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.SPQ_Q08;
    }
}