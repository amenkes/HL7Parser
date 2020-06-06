using HL7Data.Contracts.Messages.ReturnReferralInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnReferralInformationMessages
{
    public abstract class BaseReturnReferralInformationMessage : BaseMessage, IBaseReturnReferralInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RRI;
    }
}