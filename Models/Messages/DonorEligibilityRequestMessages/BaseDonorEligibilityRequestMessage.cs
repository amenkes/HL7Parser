using HL7Data.Contracts.Messages.DonorEligibilityRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DonorEligibilityRequestMessages
{
    public abstract class BaseDonorEligibilityRequestMessage : BaseMessage, IBaseDonorEligibilityRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DER;
    }
}