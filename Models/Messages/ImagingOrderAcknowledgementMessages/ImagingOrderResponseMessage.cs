using HL7Data.Contracts.Messages.ImagingOrderAcknowledgementMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.ImagingOrderAcknowledgementMessages
{
    public class ImagingOrderResponseMessage : BaseImagingOrderAcknowledgementMessage, IImagingOrderResponseMessage
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.ORI_O24;
    }
}