using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class QuantityLimitedRequest : ITableInfo
    {
        private static ITableInfo InstanceData => new QuantityLimitedRequest();
        public static ITableInfo Instance => InstanceData;
        private QuantityLimitedRequest() { }

        public int Id  => 126;
        public string Name  => "Quantity Limited Request";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"CH", "Characters"},
            {"LI", "Lines "},
            {"PG", "Pages"},
            {"RD", "Records"},
            {"ZO", "Locally defined"}
        };
    }
}

