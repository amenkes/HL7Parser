using HL7Data.Contracts.Messages.DetailFinancialTransactionsMessages;
using HL7Data.Models.Types;

namespace HL7Data.Models.Messages.DetailFinancialTransactionMessages
{
    public class PostDetailFinancialTransactionsNew : BaseDetailFinancialTransactions, IPostDetailFinancialTransactionsNew
    {
        public override TriggerEventTypes TriggerEventType => TriggerEventTypes.DFT_P11;
    }
}