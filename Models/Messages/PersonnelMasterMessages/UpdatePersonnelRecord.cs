using HL7Data.Contracts.Messages.PersonnelMasterMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.PersonnelMasterMessages
{
    public class UpdatePersonnelRecord : BasePersonnelMasterMessage, IUpdatePersonnelRecord
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.PMU_B02;
    }
}