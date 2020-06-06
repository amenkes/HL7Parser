using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class AmountType : ITableInfo
    {
        private static ITableInfo InstanceData => new AmountType();
        public static ITableInfo Instance => InstanceData;
        private AmountType() { }

        public int Id  => 146;
        public string Name  => "Amount Type";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"DF", "Differential"},
            {"LM", "Limit"},
            {"PC", "Percentage"},
            {"RT", "Rate"},
            {"UL", "Unlimited"}
        };
    }
}

