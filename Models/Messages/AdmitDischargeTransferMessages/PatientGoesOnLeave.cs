using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class PatientGoesOnLeave : BaseAdmitDischargeTransfer, IPatientGoesOnALeaveOfAbsence
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A21;
    }

#if TODO

#endif
}