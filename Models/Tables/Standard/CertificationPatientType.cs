using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class CertificationPatientType : ITableInfo
    {
        private static ITableInfo InstanceData => new CertificationPatientType();
        public static ITableInfo Instance => InstanceData;
        private CertificationPatientType() { }

        public int Id  => 150;
        public string Name  => "Certification Patient Type";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"ER", "Emergency"},
            {"IPE", "Inpatient elective"},
            {"OPE", "Outpatient elective"},
            {"UR", "Urgent"}
        };
    }
}

