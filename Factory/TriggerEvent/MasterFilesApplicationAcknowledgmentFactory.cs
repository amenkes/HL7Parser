using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.MasterFilesApplicationAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class MasterFilesApplicationAcknowledgmentFactory : AbstractTriggerEventFactory<MasterFilesApplicationAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.MFK_M01:
                    return await Task.FromResult(new MasterFileApplicationAcknowledgment());

                default:
                    return null;
            }
        }
    }
}