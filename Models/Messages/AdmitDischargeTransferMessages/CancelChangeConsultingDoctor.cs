using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class CancelChangeConsultingDoctor : BaseAdmitDischargeTransfer, ICancelChangeConsultingDoctor
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A62;
    }

#if TODO

#endif
}