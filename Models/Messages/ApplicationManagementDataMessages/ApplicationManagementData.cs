using HL7Data.Contracts.Messages.ApplicationManagementDataMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ApplicationManagementDataMessages
{
    public class ApplicationManagementData : BaseApplicationManagementDataMessage, IApplicationManagementData
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.NMD_N02;
    }
}