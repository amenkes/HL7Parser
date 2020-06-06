using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class AmbulatoryStatus : ITableInfo
    {
        private static ITableInfo InstanceData => new AmbulatoryStatus();
        public static ITableInfo Instance => InstanceData;
        private AmbulatoryStatus() { }

        public int Id => 9;
        public string Name => "Ambulatory Status";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"A0", "No functional limitations"},
            {"A1", "Ambulates with assistive device"},
            {"A2", "Wheelchair/stretcher bound"},
            {"A3", "Comatose; non-responsive"},
            {"A4", "Disoriented"},
            {"A5", "Vision impaired"},
            {"A6", "Hearing impaired"},
            {"A7", "Speech impaired"},
            {"A8", "Non-English speaking"},
            {"A9", "Functional level unknown"},
            {"B1", "Oxygen therapy"},
            {"B2", "Special equipment (tubes, IVs, catheters)"},
            {"B3", "Amputee"},
            {"B4", "Mastectomy"},
            {"B5", "Paraplegic"},
            {"B6", "Pregnant"}
        };
    }
}
