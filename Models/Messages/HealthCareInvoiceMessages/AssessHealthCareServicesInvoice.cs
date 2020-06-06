using HL7Data.Contracts.Messages.HealthCareInvoiceMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.HealthcareInvoiceMessages
{
    public class AssessHealthcareServicesInvoice : BaseHealthcareInvoiceMessage, IAssessHealthcareServicesInvoiceRequest
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.EHC_E04;
    }
}