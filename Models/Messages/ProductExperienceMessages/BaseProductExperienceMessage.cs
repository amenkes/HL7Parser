using HL7Data.Contracts.Messages.ProductExperienceMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ProductExperienceMessages
{
    public abstract class BaseProductExperienceMessage : BaseMessage, IBaseProductExperienceMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.PEX;
    }
}