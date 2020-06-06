using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class ChangePatientIdentifierList : BaseAdmitDischargeTransfer, IChangePatientIdentifierList
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A47;
    }

#if TODO

#endif
}