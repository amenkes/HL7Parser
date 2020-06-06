using HL7Data.Contracts.Messages.ApplicationManagementResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ApplicationManagementResponseMessages
{
    public class ApplicationManagementResponse : BaseApplicationManagementResponseMessage, IApplicationManagementResponse
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.NMR_N01;
    }
}