using HL7Data.Contracts.Messages.CancelQueryMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.CancelQueryMessages
{
    public abstract class BaseCancelQueryMessage : BaseMessage, IBaseCancelQueryMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.QCN;
    }
}