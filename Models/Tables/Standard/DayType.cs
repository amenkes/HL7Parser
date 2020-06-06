using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class DayType : ITableInfo
    {
        private static ITableInfo InstanceData => new DayType();
        public static ITableInfo Instance => InstanceData;
        private DayType() { }

        public int Id  => 149;
        public string Name  => "Day Type";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"AP", "Approved"},
            {"DE", "Denied"},
            {"PE", "Pending"}
        };
    }
}

