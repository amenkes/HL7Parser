using HL7Data.Contracts.Messages.HealthCareInvoiceMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.HealthcareInvoiceMessages
{
    public class AdditionalInformationResponse : BaseHealthcareInvoiceMessage, IAdditionalInformationResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.EHC_E13;
    }
}