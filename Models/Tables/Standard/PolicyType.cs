using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class PolicyType : ITableInfo
    {
        private static ITableInfo InstanceData => new PolicyType();
        public static ITableInfo Instance => InstanceData;
        private PolicyType() { }

        public int Id  => 147;
        public string Name  => "Policy Type";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"ANC", "Ancillary"},
            {"2ANC", "Second ancillary"},
            {"MMD", "Major medical"},
            {"2MMD", "Second major medical"},
            {"3MMD", "Third major medical"}
        };
    }
}

