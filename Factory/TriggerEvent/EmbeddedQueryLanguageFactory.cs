using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.EmbeddedQueryLanguageMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class EmbeddedQueryLanguageFactory : AbstractTriggerEventFactory<EmbeddedQueryLanguageFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.EQQ_Q04:
                    return await Task.FromResult(new EmbeddedQueryLanguageQuery());

                default:
                    return null;
            }
        }
    }
}