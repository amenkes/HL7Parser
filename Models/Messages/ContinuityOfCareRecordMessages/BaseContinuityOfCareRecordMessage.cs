using HL7Data.Contracts.Messages.ContinuityOfCareRecordMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ContinuityOfCareRecordMessages
{
    public abstract class BaseContinuityOfCareRecordMessage : BaseMessage, IBaseContinuityOfCareRecordMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.CCR;
    }
}