using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class Race : ITableInfo
    {
        private static ITableInfo InstanceData => new Race();
        public static ITableInfo Instance => InstanceData;
        private Race() { }

        public int Id => 5;
        public string Name => "Race";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"1002-5", "American Indian or Alaska Native"},
            {"2028-9", "Asian"},
            {"2054-5", "Black or African American"},
            {"2076-8", "Native Hawaiian or Other Pacific Islander"},
            {"2106-3", "White"},
            {"2131-1", "Other Race"}
        };
    }
}
