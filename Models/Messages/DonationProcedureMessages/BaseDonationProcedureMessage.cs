using HL7Data.Contracts.Messages.DonationProcedureMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DonationProcedureMessages
{
    public abstract class BaseDonationProcedureMessage : BaseMessage, IBaseDonationProcedureMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DPR;
    }
}