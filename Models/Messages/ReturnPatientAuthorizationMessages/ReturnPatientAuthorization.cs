using HL7Data.Contracts.Messages.ReturnPatientAuthorizationMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnPatientAuthorizationMessages
{
    public class ReturnPatientAuthorization : BaseReturnPatientAuthorizationMessage, IReturnPatientAuthorization
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RPA_I08;
    }
}