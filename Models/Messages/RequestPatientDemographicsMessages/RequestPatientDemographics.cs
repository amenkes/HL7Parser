using HL7Data.Contracts.Messages.RequestPatientDemographicsMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.RequestPatientDemographicsMessages
{
    public class RequestPatientDemographics : BaseRequestPatientDemographicsMessage, IRequestPatientDemographics
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RQP_I04;
    }
}