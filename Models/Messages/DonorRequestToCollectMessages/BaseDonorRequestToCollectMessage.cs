using HL7Data.Contracts.Messages.DonorRequestToCollectMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DonorRequestToCollectMessages
{
    public abstract class BaseDonorRequestToCollectMessage : BaseMessage, IBaseDonorRequestToCollectMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DRC;
    }
}