using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class PatientClass : ITableInfo
    {
        private static ITableInfo InstanceData => new PatientClass();
        public static ITableInfo Instance => InstanceData;
        private PatientClass() { }

        public int Id => 4;
        public string Name => "Patient Class";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"E", "Emergency"},
            {"I", "Inpatient"},
            {"O", "Outpatient"},
            {"P", "Preadmit"},
            {"R", "Recurring patient"},
            {"B", "Obstetrics"},
            {"C", "Commercial Account"},
            {"N", "Not Applicable"},
            {"U", "Unknown"}
        };
    }
}
