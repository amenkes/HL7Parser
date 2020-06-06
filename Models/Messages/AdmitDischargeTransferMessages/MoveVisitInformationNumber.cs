using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class MoveVisitInformationNumber : BaseAdmitDischargeTransfer, IMoveVisitInformationVisitNumber
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A45;
    }

#if TODO

#endif
}