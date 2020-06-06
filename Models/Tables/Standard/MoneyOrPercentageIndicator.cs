using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class MoneyOrPercentageIndicator : ITableInfo
    {
        private static ITableInfo InstanceData => new MoneyOrPercentageIndicator();
        public static ITableInfo Instance => InstanceData;
        private MoneyOrPercentageIndicator() { }

        public int Id  => 148;
        public string Name  => "Money or Percentage Indicator";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"AT", "Currency amount"},
            {"PC", "Percentage"}
        };
    }
}

