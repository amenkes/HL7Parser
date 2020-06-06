using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class ChangeOutpatientToInpatient : BaseAdmitDischargeTransfer, IChangeOutpatientToInpatient
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A06;
    }

#if TODO

#endif
}