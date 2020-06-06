using HL7Data.Contracts.Messages.PharmacyTreatmentEncodedOrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentEncodedOrderMessages
{
    public class BasePharmacyTreatmentEncodedOrderMessage : BaseMessage, IBasePharmacyTreatmentEncodedOrderMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RDE;
    }
}