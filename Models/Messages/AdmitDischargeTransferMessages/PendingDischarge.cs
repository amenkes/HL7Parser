using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class PendingDischarge : BaseAdmitDischargeTransfer, IPendingDischarge
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A16;
    }

#if TODO

#endif
}