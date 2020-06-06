using HL7Data.Contracts.Messages.BloodProductDispenseStatusMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductDispenseStatusMessages
{
    public class BloodProductDispenseStatus : BaseBloodProductDispenseStatusMessage, IBloodProductDispenseStatus
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.BPS_O29;
    }
}