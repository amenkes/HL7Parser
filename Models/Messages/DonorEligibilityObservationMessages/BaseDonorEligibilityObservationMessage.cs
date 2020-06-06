using HL7Data.Contracts.Messages.DonorEligibilityObservationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DonorEligibilityObservationMessages
{
    public abstract class BaseDonorEligibilityObservationMessage : BaseMessage, IBaseDonorEligibilityObservationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DEO;
    }
}