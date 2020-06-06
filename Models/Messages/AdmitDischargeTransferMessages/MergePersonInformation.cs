using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class MergePersonInformation : BaseAdmitDischargeTransfer, IMergePersonInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A30;
    }

#if TODO

#endif
}