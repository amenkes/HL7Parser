using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class ChargeType : ITableInfo
    {
        private static ITableInfo InstanceData => new ChargeType();
        public static ITableInfo Instance => InstanceData;
        private ChargeType() { }

        public int Id => 122;
        public string Name => "ChargeType";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"CH",  "Charge"},
            {"CO",  "Contract"},
            {"CR",  "Credit"},
            {"DP",  "Department"},
            {"GR",  "Grant"},
            {"NC",  "No Charge"},
            {"PC",  "Professional"},
            {"RS",  "Research"}
        };
    }
}
