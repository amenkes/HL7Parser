using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.NonStockRequisitionOrderMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class NonStockRequisitionOrderFactory : AbstractTriggerEventFactory<NonStockRequisitionOrderFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.OMN_O07:
                    return await Task.FromResult(new NonStockRequisitionOrder());

                default:
                    return null;
            }
        }
    }
}