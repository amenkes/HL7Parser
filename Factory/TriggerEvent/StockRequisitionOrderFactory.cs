using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.StockRequisitionOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class StockRequisitionOrderFactory : AbstractTriggerEventFactory<StockRequisitionOrderFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.OMS_O05:
                    return await Task.FromResult(new StockRequisitionOrder());

                default:
                    return null;
            }
        }
    }
}