using HL7Data.Contracts.Messages.UnsolicitedSpecimenShipmentManifestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.UnsolicitedSpecimenShipmentManifestMessages
{
    public class UnsolicitedSpecimenShipmentManifest : BaseUnsolicitedSpecimenShipmentManifestMessage, IUnsolicitedSpecimenShipmentManifest
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.OSM_R26;
    }
}