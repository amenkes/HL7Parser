using HL7Data.Contracts.Messages.PersonnelMasterMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PersonnelMasterMessages
{
    public class TerminatePracticingPerson : BasePersonnelMasterMessage, ITerminatePracticingPerson
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.PMU_B06;
    }
}