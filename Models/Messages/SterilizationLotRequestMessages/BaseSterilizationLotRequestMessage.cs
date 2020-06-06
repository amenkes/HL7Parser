using HL7Data.Contracts.Messages.SterilizationLotRequestMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SterilizationLotRequestMessages
{
    public abstract class BaseSterilizationLotRequestMessage : BaseMessage, IBaseSterilizationLotRequestMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.SLR;
    }
}