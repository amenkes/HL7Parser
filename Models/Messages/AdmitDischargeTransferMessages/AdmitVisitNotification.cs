using HL7Data.Contracts.Messages.BillingAccountMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class AdmitVisitNotification : BaseAdmitDischargeTransfer, IAdmitVisitNotification
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A01;
    }
}