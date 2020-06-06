//TransactionType Transaction Type

using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class TransactionType : ITableInfo
    {
        private static ITableInfo InstanceData => new TransactionType();
        public static ITableInfo Instance => InstanceData;
        private TransactionType() { }

        public int Id => 17;
        public string Name => "Transaction Type";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"CG", "Charge"},
            {"CD", "Credit"},
            {"PY", "Payment"},
            {"AJ", "Adjustment"},
            {"CO", "Co-payment"}
        };
    }
}
