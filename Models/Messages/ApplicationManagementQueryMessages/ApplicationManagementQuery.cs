using HL7Data.Contracts.Messages.ApplicationManagementQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ApplicationManagementQueryMessages
{
    public class ApplicationManagementQuery : BaseApplicationManagementQueryMessage, IApplicationManagementQuery
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.NMQ_N01;
    }
}