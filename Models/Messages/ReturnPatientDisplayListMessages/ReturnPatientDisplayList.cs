using HL7Data.Contracts.Messages.ReturnPatientDisplayListMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnPatientDisplayListMessages
{
    public class ReturnPatientDisplayList : BaseReturnPatientDisplayListMessage, IReturnPatientDisplayList
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RPL_I02;
    }
}