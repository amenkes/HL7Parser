using HL7Data.Contracts.Messages.ImagingOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ImagingOrderMessages
{
    public class ImagingOrder : BaseImagingOrderMessage, IImagingOrder
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OMI_O23;
    }
}