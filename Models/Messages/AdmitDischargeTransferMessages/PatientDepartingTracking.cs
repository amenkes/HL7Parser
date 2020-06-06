using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class PatientDepartingTracking : BaseAdmitDischargeTransfer, IPatientDepartingTracking
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A09;
    }

#if TODO

#endif
}