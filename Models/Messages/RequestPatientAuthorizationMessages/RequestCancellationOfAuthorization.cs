using HL7Data.Contracts.Messages.RequestPatientAuthorizationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.RequestPatientAuthorizationMessages
{
    public class RequestCancellationOfAuthorization : BaseRequestPatientAuthorizationMessage, IRequestCancellationOfAuthorization
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RQA_I11;
    }
}