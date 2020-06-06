using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class UpdateAllergyInformation : BaseAdmitDischargeTransfer, IUpdateAllergyInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A60;
    }

#if TODO

#endif
}