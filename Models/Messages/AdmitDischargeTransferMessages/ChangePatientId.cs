using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class ChangePatientId : BaseAdmitDischargeTransfer, IChangePatientId
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A46;
    }

#if TODO

#endif
}