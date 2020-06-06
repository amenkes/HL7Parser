using HL7Data.Contracts.Messages.BloodProductTransfusionDispositionMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.BloodProductTransfusionDispositionMessages
{
    public class BloodProductTransfusionDisposition : BaseBloodProductTransfusionDispositionMessage, IBloodProductTransfusionDisposition
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.BTS_O31;
    }
}