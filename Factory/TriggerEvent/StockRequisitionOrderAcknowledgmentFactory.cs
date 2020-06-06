using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.StockRequisitionOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class StockRequisitionOrderAcknowledgmentFactory : AbstractTriggerEventFactory<StockRequisitionOrderAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ORS_O06:
                    return await Task.FromResult(new StockRequisitionAcknowledgement());

                default:
                    return null;
            }
        }
    }
}