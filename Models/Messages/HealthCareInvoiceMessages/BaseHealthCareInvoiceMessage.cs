using HL7Data.Contracts.Messages.HealthCareInvoiceMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.HealthcareInvoiceMessages
{
    public abstract class BaseHealthcareInvoiceMessage : BaseMessage, IBaseHealthcareInvoiceMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.EHC;
    }
}