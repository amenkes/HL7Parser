using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class ReadmissionIndicator : ITableInfo
    {
        private static ITableInfo InstanceData => new ReadmissionIndicator();
        public static ITableInfo Instance => InstanceData;
        private ReadmissionIndicator() { }

        public int Id => 92;
        public string Name => "Re-Admission Indicator";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"R", "Re-admission"}
        };
    }
}
