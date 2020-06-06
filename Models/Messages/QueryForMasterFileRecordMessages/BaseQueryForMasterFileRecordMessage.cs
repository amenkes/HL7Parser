using HL7Data.Contracts.Messages.QueryForMasterFileRecordMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryForMasterFileRecordMessages
{
    public abstract class BaseQueryForMasterFileRecordMessage : BaseMessage, IBaseQueryForMasterFileRecordMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.MFQ;
    }
}