using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class CancelPendingTransfer : BaseAdmitDischargeTransfer, ICancelPendingTransfer
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A26;
    }
}