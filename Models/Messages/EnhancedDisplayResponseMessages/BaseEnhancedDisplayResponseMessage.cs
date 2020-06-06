using HL7Data.Contracts.Messages.EnhancedDisplayResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.EnhancedDisplayResponseMessages
{
    public abstract class BaseEnhancedDisplayResponseMessage : BaseMessage, IBaseEnhancedDisplayResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.EDR;
    }
}