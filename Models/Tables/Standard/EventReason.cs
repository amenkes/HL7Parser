using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class EventReason : ITableInfo
    {
        private static ITableInfo InstanceData => new EventReason();
        public static ITableInfo Instance => InstanceData;
        private EventReason() { }

        public int Id => 62;
        public string Name => "Event Reason";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"01", "Patient request"},
            {"02", "Physician/health practitioner order"},
            {"03", "Census management"},
            {"O", "Other"},
            {"U", "Unknown"}
        };
    }
}

//