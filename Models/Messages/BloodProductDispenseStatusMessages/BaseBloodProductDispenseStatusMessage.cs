using HL7Data.Contracts.Messages.BloodProductDispenseStatusMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductDispenseStatusMessages
{
    public abstract class BaseBloodProductDispenseStatusMessage : BaseMessage, IBaseBloodProductDispenseStatusMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.BPS;
    }
}