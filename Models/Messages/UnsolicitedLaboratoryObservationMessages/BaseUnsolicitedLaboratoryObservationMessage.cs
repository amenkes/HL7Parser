using HL7Data.Contracts.Messages.UnsolicitedLaboratoryObservationMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedLaboratoryObservationMessages
{
    public abstract class BaseUnsolicitedLaboratoryObservationMessage : BaseMessage, IBaseUnsolicitedLaboratoryObservationMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OUL;
    }
}