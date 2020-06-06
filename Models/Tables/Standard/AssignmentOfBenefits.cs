using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class AssignmentOfBenefits : ITableInfo
    {
        private static ITableInfo InstanceData => new AssignmentOfBenefits();
        public static ITableInfo Instance => InstanceData;
        private AssignmentOfBenefits() { }

        public int Id  => 135;
        public string Name  => "Assignment of Benefits";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"Y", "Yes"},
            {"N", "No"},
            {"M", "Modified assignment"}
        };
    }
}

