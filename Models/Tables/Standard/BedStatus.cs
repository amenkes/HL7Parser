using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class BedStatus : ITableInfo
    {
        private static ITableInfo InstanceData => new BedStatus();
        public static ITableInfo Instance => InstanceData;
        private BedStatus() { }

        public int Id => 116;
        public string Name => "Bed Status";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"C", "Closed"},
            {"H", "Housekeeping"},
            {"O", "Occupied"},
            {"U", "Unoccupied"},
            {"K", "Contaminated"},
            {"I", "Isolated"}
        };
    }
}
