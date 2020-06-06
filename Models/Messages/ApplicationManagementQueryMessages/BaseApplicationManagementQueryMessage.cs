using HL7Data.Contracts.Messages.ApplicationManagementQueryMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ApplicationManagementQueryMessages
{
    public abstract class BaseApplicationManagementQueryMessage : BaseMessage, IBaseApplicationManagementQueryMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.NMQ;
    }
}