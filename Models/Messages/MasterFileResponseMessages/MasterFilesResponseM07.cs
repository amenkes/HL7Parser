using HL7Data.Contracts.Messages.MasterFileResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.MasterFileResponseMessages
{
    // Could not find any naming / differences for M04, M05, M06 and M07, so use hokey names for now.
    public class MasterFilesResponseM07 : BaseMasterFileResponseMessage, IMasterFileResponseM07
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.MFR_M07;
    }
}