using HL7Data.Contracts.Messages.TabularDataResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.TabularDataResponseMessages
{
    public abstract class BaseTabularDataResponseMessage : BaseMessage, IBaseTabularDataResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.TBR;
    }
}