using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.QueryForOrderStatusMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class QueryForOrderStatusFactory : AbstractTriggerEventFactory<QueryForOrderStatusFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.OSQ_Q06:
                    return await Task.FromResult(new QueryForOrderStatus());

                default:
                    return null;
            }
        }
    }
}