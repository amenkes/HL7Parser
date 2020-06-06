using HL7Data.Contracts.Messages.PharmacyTreatmentAdministrationInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentAdministrationInformationMessages
{
    public abstract class BasePharmacyTreatmentAdministrationInformationMessage : BaseMessage, IBasePharmacyTreatmentAdministrationInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RAR;
    }
}