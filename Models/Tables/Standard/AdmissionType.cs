using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class AdmissionType : ITableInfo
    {
        private static ITableInfo InstanceData => new AdmissionType();
        public static ITableInfo Instance => InstanceData;
        private AdmissionType() { }

        public int Id => 7;
        public string Name => "Admission Type";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"A", "Accident"},
            {"E", "Emergency"},
            {"L", "Labor and Delivery"},
            {"R", "Routine"},
            {"N", "Newborn (Birth in Healthcare facility)"},
            {"U", "Urgent"},
            {"C", "Elective"}
        };
    }
}
