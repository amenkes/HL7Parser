using HL7Data.Contracts.Messages.ResponseToVaccinationQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ResponseToVaccinationQueryMessages
{
    public class ResponseToVaccinationQuery : BaseResponseToVaccinationQueryMessage, IResponseToVaccinationQuery
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.VXX_V02;
    }
}