using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.QueryResponseForOrderStatusMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class QueryResponseForOrderStatusFactory : AbstractTriggerEventFactory<QueryResponseForOrderStatusFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.OSR_Q06:
                    return await Task.FromResult(new QueryResponseForOrderStatus());

                default:
                    return null;
            }
        }
    }
}