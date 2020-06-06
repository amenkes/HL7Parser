using HL7Data.Contracts.Messages.UnsolicitedStudyDataMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedStudyDataMessages
{
    public abstract class BaseUnsolicitedStudyDataMessage : BaseMessage, IBaseUnsolicitedStudyDataMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.CSU;
    }
}