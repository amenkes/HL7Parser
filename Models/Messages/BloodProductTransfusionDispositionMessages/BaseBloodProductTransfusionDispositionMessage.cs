using HL7Data.Contracts.Messages.BloodProductTransfusionDispositionMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductTransfusionDispositionMessages
{
    public abstract class BaseBloodProductTransfusionDispositionMessage : BaseMessage, IBaseBloodProductTransfusionDispositionMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.BTS;
    }
}