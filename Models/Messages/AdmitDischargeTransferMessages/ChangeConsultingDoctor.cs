using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class ChangeConsultingDoctor : BaseAdmitDischargeTransfer, IChangeConsultingDoctor
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A61;
    }

#if TODO

#endif
}