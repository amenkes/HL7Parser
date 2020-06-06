using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class ChangeVisitNumber : BaseAdmitDischargeTransfer, IChangeVisitNumber
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A50;
    }

#if TODO

#endif
}