using HL7Data.Contracts.Messages.MasterFileResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MasterFileResponseMessages
{
    public abstract class BaseMasterFileResponseMessage : BaseMessage, IBaseMasterFileResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.MFR; //TODO: 4, 5, 6
    }
}