using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class MergeVisitNumber : BaseAdmitDischargeTransfer, IMergeVisitVisitNumber
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A42;
    }

#if TODO

#endif
}