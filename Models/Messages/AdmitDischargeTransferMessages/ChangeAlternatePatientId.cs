using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class ChangeAlternatePatientId : BaseAdmitDischargeTransfer, IChangeAlternatePatientId
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A48;
    }

#if TODO

#endif
}