using HL7Data.Contracts.Messages.MedicalDocumentManagementMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MedicalDocumentManagementMessages
{
    public class DocumentCancelNotification : BaseMedicalDocumentManagementMessage, IDocumentCancelNotification
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.MDM_T11;
    }
}