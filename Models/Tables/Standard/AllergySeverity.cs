using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class AllergySeverity : ITableInfo
    {
        private static ITableInfo InstanceData => new AllergySeverity();
        public static ITableInfo Instance => InstanceData;
        private AllergySeverity() { }

        public int Id  => 128;
        public string Name  => "Allergy Severity";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"SV", "Severe"},
            {"MO", "Moderate"},
            {"MI", "Mild"},
            {"U", "Unknown"}
        };
    }
}

