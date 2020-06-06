using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class QueryPriority : ITableInfo
    {
        private static ITableInfo InstanceData => new QueryPriority();
        public static ITableInfo Instance => InstanceData;
        private QueryPriority() { }

        public int Id => 1;
        public string Name => "Query Priority";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"D", "Deferred"},
            {"I", "Immediate"}
        };
    }
}
