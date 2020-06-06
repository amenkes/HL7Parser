using HL7Data.Contracts.Messages.SpecimenShipmentMessages;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.SpecimenShipmentMessages
{
    public abstract class BaseSpecimenShipmentMessage : BaseMessage, IBaseSpecimenShipmentMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OSM;
    }
}