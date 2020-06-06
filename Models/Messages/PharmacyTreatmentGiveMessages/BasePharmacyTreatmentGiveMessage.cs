using HL7Data.Contracts.Messages.PharmacyTreatmentGiveMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentGiveMessages
{
    public class BasePharmacyTreatmentGiveMessage : BaseMessage, IBasePharmacyTreatmentGiveMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RGV;
    }
}