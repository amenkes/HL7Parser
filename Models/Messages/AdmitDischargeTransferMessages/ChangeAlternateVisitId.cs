using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class ChangeAlternateVisitId : BaseAdmitDischargeTransfer, IChangeAlternateVisitId
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A51;
    }

#if TODO

#endif
}