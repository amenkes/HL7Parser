using HL7Data.Contracts.Messages.PharmacyTreatmentDoseInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentDoseInformationMessages
{
    public abstract class BasePharmacyTreatmentDoseInformationMessage : BaseMessage, IBasePharmacyTreatmentDoseInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RGR;
    }
}