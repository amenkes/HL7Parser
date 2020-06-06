using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class MilitaryStatus : ITableInfo
    {
        private static ITableInfo InstanceData => new MilitaryStatus();
        public static ITableInfo Instance => InstanceData;
        private MilitaryStatus() { }

        public int Id  => 142;
        public string Name  => "Military Status";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"ACT", "Active duty"},
            {"RET", "Retired"},
            {"DEC", "Deceased"}
        };
    }
}

