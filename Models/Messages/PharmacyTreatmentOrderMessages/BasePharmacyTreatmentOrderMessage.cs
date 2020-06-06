using HL7Data.Contracts.Messages.PharmacyTreatmentOrderMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentOrderMessages
{
    public abstract class BasePharmacyTreatmentOrderMessage : BaseMessage, IPharmacyTreatmentOrder
    {
        public override HL7MessageType MessageType => HL7MessageType.OMP;
    }
}