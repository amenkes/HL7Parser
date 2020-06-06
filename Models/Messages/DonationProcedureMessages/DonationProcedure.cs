using HL7Data.Contracts.Messages.DonationProcedureMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DonationProcedureMessages
{
    public class DonationProcedure : BaseDonationProcedureMessage, IDonationProcedure
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.DPR_048;
    }
}