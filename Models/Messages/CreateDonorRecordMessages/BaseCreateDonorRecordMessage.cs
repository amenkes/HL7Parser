using HL7Data.Contracts.Messages.CreateDonorRecordMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CreateDonorRecordMessages
{
    public abstract class BaseCreateDonorRecordMessage : BaseMessage, IBaseCreateDonorRecordMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DBC;
    }
}