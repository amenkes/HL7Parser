using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class UpdatePersonInformation : BaseAdmitDischargeTransfer, IUpdatePersonInformation
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A31;
    }

#if TODO

#endif
}