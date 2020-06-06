using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class DiagnosisType : ITableInfo
    {
        private static ITableInfo InstanceData => new DiagnosisType();
        public static ITableInfo Instance => InstanceData;
        private DiagnosisType() { }

        public int Id => 52;
        public string Name => "Diagnosis Type";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"A", "Admitting"},
            {"W", "Working"},
            {"F", "Final"}
        };
    }
}
