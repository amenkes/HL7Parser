using HL7Data.Contracts.Messages.VirtualTableQueryMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.VirtualTableQueryMessages
{
    public abstract class BaseVirtualTableQueryMessage : BaseMessage, IBaseVirtualTableQueryMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.VQQ;
    }
}