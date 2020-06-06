using HL7Data.Contracts.Messages.DiagnosisRelatedGroupMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DiagnosisRelatedGroupMessages
{
    public abstract class BaseDiagnosisRelatedGroupMessage : BaseMessage, IBaseDiagnosisRelatedGroupMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.DRG;
    }
}