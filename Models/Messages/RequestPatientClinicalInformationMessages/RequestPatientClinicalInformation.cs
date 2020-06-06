using HL7Data.Contracts.Messages.RequestPatientClinicalInformationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.RequestPatientClinicalInformationMessages
{
    public class RequestPatientClinicalInformation : BaseRequestPatientClinicalInformationMessage, IRequestPatientClinicalInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RQC_I05;
    }
}