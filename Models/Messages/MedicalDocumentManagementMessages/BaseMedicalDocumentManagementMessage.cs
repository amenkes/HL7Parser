using HL7Data.Contracts.Messages.MedicalDocumentManagementMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MedicalDocumentManagementMessages
{
    public abstract class BaseMedicalDocumentManagementMessage : BaseMessage, IBaseMedicalDocumentManagementMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.MDM;
    }
}