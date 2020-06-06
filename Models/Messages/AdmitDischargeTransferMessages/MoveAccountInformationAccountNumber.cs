using HL7Data.Contracts.Messages.AdmitDischargeTransferMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.AdmitDischargeTransferMessages
{
    public class MoveAccountInformationAccountNumber : BaseAdmitDischargeTransfer, IMoveAccountInformationPatientAccountNumber
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ADT_A44;
    }

#if TODO

#endif
}