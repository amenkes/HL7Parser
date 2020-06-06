using HL7Data.Contracts.Messages.UnsolicitedDisplayUpdateMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedDisplayUpdateMessages
{
    public abstract class BaseUnsolicitedDisplayUpdateMessage : BaseMessage, IBaseUnsolicitedDisplayUpdateMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.UDM;
    }
}