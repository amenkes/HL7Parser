using HL7Data.Contracts.Messages.PharmacyPrescriptionOrderQueryResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyPrescriptionOrderQueryResponseMessages
{
    public abstract class BasePharmacyPrescriptionOrderQueryResponseMessage : BaseMessage, IBasePharmacyPrescriptionOrderQueryResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.ROR;
    }
}