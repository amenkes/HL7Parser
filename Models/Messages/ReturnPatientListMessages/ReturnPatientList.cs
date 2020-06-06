using HL7Data.Contracts.Messages.ReturnPatientListMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ReturnPatientListMessages

{
    public class ReturnPatientList : BaseReturnPatientListMessage, IReturnPatientList
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.RPR_I03;
    }
}