using HL7Data.Contracts.Messages.DetailFinancialTransactionsMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DetailFinancialTransactionMessages
{
    public class PostDetailFinancialTransactions : BaseDetailFinancialTransactions, IPostDetailFinancialTransactions
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.DFT_P03;
    }
}