using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class UpdatePatientInformation : BaseAdmitDischargeTransfer, IUpdatePatientInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A08;
    }

#if TODO

#endif
}