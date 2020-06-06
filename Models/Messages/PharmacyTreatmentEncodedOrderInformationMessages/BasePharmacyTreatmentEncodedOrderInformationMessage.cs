using HL7Data.Contracts.Messages.PharmacyTreatmentEncodedOrderInformationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PharmacyTreatmentEncodedOrderInformationMessages
{
    public abstract class BasePharmacyTreatmentEncodedOrderInformationMessage : BaseMessage, IBasePharmacyTreatmentEncodedOrderInformationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.RER;
    }
}