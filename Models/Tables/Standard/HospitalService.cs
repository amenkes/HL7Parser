using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class HospitalService : ITableInfo
    {
        private static ITableInfo InstanceData => new HospitalService();
        public static ITableInfo Instance => InstanceData;
        private HospitalService() { }

        public int Id => 69;
        public string Name => "Hospital Service";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"MED", "Medical Service"},
            {"SUR", "Surgical Service"},
            {"URO", "Urology Service"},
            {"PUL", "Pulmonary Service"},
            {"CAR", "Cardiac Service"}
        };
    }
}
