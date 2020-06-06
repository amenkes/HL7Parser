using HL7Data.Contracts.Messages.QueryByParameterMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryByParameterMessages
{
    public abstract class BaseQueryByParameterMessage : BaseMessage, IBaseQueryByParameterMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.QBP;
    }
}