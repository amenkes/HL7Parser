using HL7Data.Contracts.Messages.RequestPatientInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.RequestPatientInformationMessages
{
    public class RequestForInsuranceInformation : BaseRequestPatientInformationMessage, IRequestForInsuranceInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RQI_I01;
    }
}