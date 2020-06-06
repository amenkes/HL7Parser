using HL7Data.Contracts.Messages.QueryForVaccinationRecordMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.QueryForVaccinationRecordMessages
{
    public abstract class BaseQueryForVaccinationRecordMessage : BaseMessage, IBaseQueryForVaccinationRecordMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.VXQ;
    }
}