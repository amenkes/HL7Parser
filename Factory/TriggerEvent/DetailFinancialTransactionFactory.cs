using System.Threading.Tasks;
using HL7Data.Contracts.Base;
using HL7Data.Contracts.Generics;
using HL7Data.Factory.Base;
using HL7Data.Models.Messages.DetailFinancialTransactionMessages;
using HL7Data.Models.Types;

namespace HL7Data.Factory.TriggerEvent
{
    public sealed class DetailFinancialTransactionFactory : AbstractTriggerEventFactory<DetailFinancialTransactionFactory>
    {
        public override async Task<IMessage> GetElementFromType(TriggerEventTypes triggerEventType, IGenericMessage genericMessage)
        {
            switch (triggerEventType)
            {
                case TriggerEventTypes.DFT_P03:
                    return await Task.FromResult(new PostDetailFinancialTransactions());

                case TriggerEventTypes.DFT_P11:
                    return await Task.FromResult(new PostDetailFinancialTransactionsNew());

                default:
                    return null;
            }
        }
    }
}