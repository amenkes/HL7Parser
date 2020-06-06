using HL7Data.Contracts.Messages.BloodProductOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductOrderMessages
{
    public class BloodProductOrder : BaseBloodProductOrderMessage, IBloodProductOrder
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OMB_O27;
    }
}