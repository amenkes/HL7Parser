using HL7Data.Contracts.Messages.DietaryOrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DietaryOrderMessages
{
    public abstract class BaseDietaryOrderMessage : BaseMessage, IBaseDietaryOrderMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OMD;
    }
}