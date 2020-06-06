using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class MergePatientInformationPatientIdOnly : BaseAdmitDischargeTransfer, IMergePatientInformationPatientIdOnly
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A34;
    }

#if TODO

#endif
}