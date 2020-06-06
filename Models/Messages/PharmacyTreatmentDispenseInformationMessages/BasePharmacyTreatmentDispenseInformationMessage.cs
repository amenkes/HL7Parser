using HL7Data.Contracts.Messages.PharmacyTreatmentDispenseInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentDispenseInformationMessages
{
    public abstract class BasePharmacyTreatmentDispenseInformationMessage : BaseMessage, IBasePharmacyTreatmentDispenseInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RDR;
    }
}