using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class VersionId : ITableInfo
    {
        private static ITableInfo InstanceData => new VersionId();
        public static ITableInfo Instance => InstanceData;
        private VersionId() { }

        public int Id => 104;
        public string Name => "Version ID";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"2.0", "Release 2.0"},
            {"2.0", "Demo 2.0"},
            {"2.1", "Release 2.1"},
            {"2.2", "Release 2.2"},
            {"2.3", "Release 2.3"},
            {"2.3.1", "Release 2.3.1"},
            {"2.4", "Release 2.4"},
            {"2.5", "Release 2.5"},
            {"2.5.1", "Release 2.5.1"},
            {"2.6", "Release 2.6"},
            {"2.7", "Release 2.7"},
            {"2.7.1", "Release 2.7.1"},
            {"2.8", "Release 2.8"}
        };
    }
}
