using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class MergePatientInformation : BaseAdmitDischargeTransfer, IMergePatientInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A18;
    }

#if TODO

#endif
}