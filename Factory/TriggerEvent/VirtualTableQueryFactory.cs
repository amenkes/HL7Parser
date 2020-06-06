using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.VirtualTableQueryMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class VirtualTableQueryFactory : AbstractTriggerEventFactory<VirtualTableQueryFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.VQQ_Q07:
                    return await Task.FromResult(new VirtualTableQuery());

                default:
                    return null;
            }
        }
    }
}