using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MasterFilesNotificationMessages
{
    public class BaseMasterFileNotificationMessages : BaseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.MFN;
    }
}