using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.CancelQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class CancelQueryFactory : AbstractTriggerEventFactory<CancelQueryFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.QCN_J01:
                    return await Task.FromResult(new CancelQueryAcknowledgeMessage());

                default:
                    return null;
            }
        }
    }
}