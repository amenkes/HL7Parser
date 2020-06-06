using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class ReleaseInformation : ITableInfo
    {
        private static ITableInfo InstanceData => new ReleaseInformation();
        public static ITableInfo Instance => InstanceData;
        private ReleaseInformation() { }

        public int Id => 93;
        public string Name => "ReleaseInformation";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"Y", "Yes"},
            {"N", "No"},
            {"...", "user-defined codes"} //TODO: Verify this
        };
    }
}
