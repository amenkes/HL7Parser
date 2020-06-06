using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.NonStockRequisitionGeneralOrderAcknowledgmentMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class NonStockRequisitionGeneralOrderAcknowledgmentFactory : AbstractTriggerEventFactory<NonStockRequisitionGeneralOrderAcknowledgmentFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.ORN_O08:
                    return await Task.FromResult(new NonStockRequisitionAcknowledgement());

                default:
                    return null;
            }
        }
    }
}