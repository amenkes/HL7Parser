using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class ProcedureCode : ITableInfo
    {
        private static ITableInfo InstanceData => new ProcedureCode();
        public static ITableInfo Instance => InstanceData;
        private ProcedureCode() { }

        public int Id => 88;
        public string Name => "Procedure Code";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"C4", "CPT-4"},
            {"C5", "CPT-5  "},
            {"HCPCS", "CMS (formerly HCFA)  Common Procedure Coding System"},
            {"HPC", "CMS (formerly HCFA )Procedure Codes (HCPCS)"},
            {"I10P", "ICD-10  Procedure Codes"},
            {"SCT", "SNOMED CT"}
        };
    }
}
