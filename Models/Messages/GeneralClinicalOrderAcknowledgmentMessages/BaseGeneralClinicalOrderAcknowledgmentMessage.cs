using HL7Data.Contracts.Messages.GeneralClinicalOrderAcknowledgmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.GeneralClinicalOrderAcknowledgmentMessages
{
    public abstract class BaseGeneralClinicalOrderAcknowledgmentMessage : BaseMessage, IBaseGeneralClinicalOrderAcknowledgmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ORG;
    }
}