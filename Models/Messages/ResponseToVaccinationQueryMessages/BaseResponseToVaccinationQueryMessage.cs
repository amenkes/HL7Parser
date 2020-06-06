using HL7Data.Contracts.Messages.ResponseToVaccinationQueryMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ResponseToVaccinationQueryMessages
{
    public abstract class BaseResponseToVaccinationQueryMessage : BaseMessage, IBaseResponseToVaccinationQueryMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.VXX;
    }
}