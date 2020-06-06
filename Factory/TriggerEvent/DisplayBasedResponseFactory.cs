using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.DisplayBasedResponseMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class DisplayBasedResponseFactory : AbstractTriggerEventFactory<DisplayBasedResponseFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.RDY_K15:
                    return await Task.FromResult(new DisplayBasedResponse());

                case TriggerEventTypes.RDY_Z80:
                    return await Task.FromResult(new DispenseInformationResponse());

                case TriggerEventTypes.RDY_Z98:
                    return await Task.FromResult(new DispenseHistoryResponse());

                default:
                    return null;
            }
        }
    }
}