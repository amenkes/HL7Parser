using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedSpecimenShipmentManifestMessages
{
    public class BaseUnsolicitedSpecimenShipmentManifestMessage : BaseMessage
    {
        public override HL7MessageType MessageType => HL7MessageType.OSM;
    }
}