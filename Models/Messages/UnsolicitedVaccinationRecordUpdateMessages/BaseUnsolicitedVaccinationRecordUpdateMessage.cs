using HL7Data.Contracts.Messages.UnsolicitedVaccinationRecordUpdateMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedVaccinationRecordUpdateMessages
{
    public abstract class BaseUnsolicitedVaccinationRecordUpdateMessage : BaseMessage, IBaseUnsolicitedVaccinationRecordUpdateMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.VXU;
    }
}