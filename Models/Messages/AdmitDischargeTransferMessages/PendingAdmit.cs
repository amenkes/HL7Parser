using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class PendingAdmit : BaseAdmitDischargeTransfer, IPendingAdmit
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A14;
    }

#if TODO

#endif
}