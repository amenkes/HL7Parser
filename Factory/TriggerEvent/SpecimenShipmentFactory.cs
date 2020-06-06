using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.UnsolicitedSpecimenShipmentManifestMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class SpecimenShipmentFactory : AbstractTriggerEventFactory<SpecimenShipmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.OSM_R26:
                    return await Task.FromResult(new UnsolicitedSpecimenShipmentManifest());

                default:
                    return null;
            }
        }
    }
}