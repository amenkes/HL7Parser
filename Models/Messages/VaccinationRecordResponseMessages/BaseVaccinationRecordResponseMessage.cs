using HL7Data.Contracts.Messages.VaccinationRecordResponseMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.VaccinationRecordResponseMessages
{
    public abstract class BaseVaccinationRecordResponseMessage : BaseMessage, IBaseVaccinationRecordResponseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.VXR;
    }
}