using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class EligibilitySource : ITableInfo
    {
        private static ITableInfo InstanceData => new EligibilitySource();
        public static ITableInfo Instance => InstanceData;
        private EligibilitySource() { }

        public int Id  => 144;
        public string Name  => "Eligibility Source";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"1", "Insurance company"},
            {"2", "Employer"},
            {"3", "Insured presented policy"},
            {"4", "Insured presented card"},
            {"5", "Signed statement on file"},
            {"6", "Verbal information"},
            {"7", "None"}
        };
    }
}

