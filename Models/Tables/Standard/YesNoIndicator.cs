using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class YesNoIndicator : ITableInfo
    {
        private static ITableInfo InstanceData => new YesNoIndicator();
        public static ITableInfo Instance => InstanceData;
        private YesNoIndicator() { }

        public int Id  => 136;
        public string Name  => "Yes/No Indicator";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"Y", "Yes"},
            {"N", "No"}
        };
    }
}

