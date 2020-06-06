using HL7Data.Contracts.Messages.PatientGoalMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PatientGoalMessages
{
    public class PcGoalAdd : BasePatientGoalMessage, IPcGoalAdd
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.PGL_PC6;
    }
}