using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class RegisterPatient : BaseAdmitDischargeTransfer, IRegisterPatient
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A04;
    }

#if TODO

#endif
}