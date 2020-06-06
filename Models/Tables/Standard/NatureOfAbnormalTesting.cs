using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class NatureOfAbnormalTesting : ITableInfo
    {
        private static ITableInfo InstanceData => new NatureOfAbnormalTesting();
        public static ITableInfo Instance => InstanceData;
        private NatureOfAbnormalTesting() { }

        public int Id => 80;
        public string Name => "Nature of Abnormal Testing";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"A", "An age-based population"},
            {"N", "None - generic normal range"},
            {"R", "A race-based population"},
            {"S", "A sex-based population"},
            {"SP", "Species"},
            {"B", "Breed"},
            {"ST", "Strain"}
        };
    }
}
