using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class PatientReturnFromAbsence : BaseAdmitDischargeTransfer, IPatientReturnsFromALeaveOfAbsence
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A22;
    }

#if TODO

#endif
}