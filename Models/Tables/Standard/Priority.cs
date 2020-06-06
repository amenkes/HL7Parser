using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class Priority : ITableInfo
    {
        private static ITableInfo InstanceData => new Priority();
        public static ITableInfo Instance => InstanceData;
        private Priority() { }

        public int Id => 27;
        public string Name => "Priority";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"S", "Stat (do immediately)"},
            {"A", "As soon as possible (a priority lower than stat)"},
            {"R", "Routine"},
            {"P", "Preoperative (to be done prior to surgery)"},
            {"T", "Timing critical (do as near as possible to requested time)"}
        };
    }
}
