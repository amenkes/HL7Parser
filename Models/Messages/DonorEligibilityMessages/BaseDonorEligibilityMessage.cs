using HL7Data.Contracts.Messages.DonorEligibilityMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DonorEligibilityMessages
{
    public abstract class BaseDonorEligibilityMessage : BaseMessage, IBaseDonorEligibilityMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DEL;
    }
}