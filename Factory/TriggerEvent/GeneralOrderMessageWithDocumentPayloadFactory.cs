using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Types;

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously - Factory incomplete. Will by async when implemented

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class GeneralOrderMessageWithDocumentPayloadFactory : AbstractTriggerEventFactory<GeneralOrderMessageWithDocumentPayloadFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            //TODO
            switch (triggerEventType)
            {
                default:
                    return null;
            }
        }
    }
}