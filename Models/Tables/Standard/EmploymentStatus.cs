using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class EmploymentStatus : ITableInfo
    {
        private static ITableInfo InstanceData => new EmploymentStatus();
        public static ITableInfo Instance => InstanceData;
        private EmploymentStatus() { }

        public int Id => 66;
        public string Name => "Employment Status";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"1", "Full time employed"},
            {"2", "Part time employed"},
            {"4", "Self-employed,"},
            {"C", "Contract, per diem"},
            {"L", "Leave of absence (e.g., family leave, sabbatical, etc.)"},
            {"T", "Temporarily unemployed"},
            {"3", "Unemployed"},
            {"5", "Retired"},
            {"6", "On active military duty"},
            {"O", "Other"},
            {"9", "Unknown"}
        };
    }
}
