using HL7Data.Contracts.Messages.MasterFilesApplicationAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MasterFilesApplicationAcknowledgmentMessages
{
    public abstract class BaseMasterFilesApplicationAcknowledgmentMessage : BaseMessage, IBaseMasterFilesApplicationAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.MFK;
    }
}