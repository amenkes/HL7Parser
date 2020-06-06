using HL7Data.Contracts.Messages.StoredProcedureRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.StoredProcedureRequestMessages
{
    public abstract class BaseStoredProcedureRequestMessage : BaseMessage, IBaseStoredProcedureRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SPQ;
    }
}