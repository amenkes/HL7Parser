using HL7Data.Contracts.Messages.UpdateDonorRecordMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UpdateDonorRecordMessages
{
    public abstract class BaseUpdateDonorRecordMessage : BaseMessage, IBaseUpdateDonorRecordMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DBU;
    }
}