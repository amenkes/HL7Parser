using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class LinkPatientInformation : BaseAdmitDischargeTransfer, ILinkPatientInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A24;
    }

#if TODO

#endif
}