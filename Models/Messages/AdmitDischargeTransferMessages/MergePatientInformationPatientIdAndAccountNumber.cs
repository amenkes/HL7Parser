using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class MergePatientInformationPatientIdAndAccountNumber : BaseAdmitDischargeTransfer, IMergePatientInformationPatientIdAndAccountNumber
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A36;
    }

#if TODO

#endif
}