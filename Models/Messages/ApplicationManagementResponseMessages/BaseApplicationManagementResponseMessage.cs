using HL7Data.Contracts.Messages.ApplicationManagementResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ApplicationManagementResponseMessages
{
    public class BaseApplicationManagementResponseMessage : BaseMessage, IBaseApplicationManagementResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.NMR;
    }
}