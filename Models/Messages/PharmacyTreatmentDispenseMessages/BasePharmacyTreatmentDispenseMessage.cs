using HL7Data.Contracts.Messages.PharmacyTreatmentDispenseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentDispenseMessages
{
    public abstract class BasePharmacyTreatmentDispenseMessage : BaseMessage, IBasePharmacyTreatmentDispenseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RDS;
    }
}