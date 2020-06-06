using HL7Data.Contracts.Messages.ApplicationManagementDataMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ApplicationManagementDataMessages
{
    public abstract class BaseApplicationManagementDataMessage : BaseMessage, IBaseApplicationManagementDataMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.NMD;
    }
}