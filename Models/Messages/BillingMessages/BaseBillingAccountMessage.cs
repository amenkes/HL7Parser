using HL7Data.Contracts.Messages.BillingAccountMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BillingMessages
{
    public abstract class BaseBillingAccountMessage : BaseMessage, IBaseBillingAccountMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.BAR;
    }
}