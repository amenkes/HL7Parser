using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class OutlierType : ITableInfo
    {
        private static ITableInfo InstanceData => new OutlierType();
        public static ITableInfo Instance => InstanceData;
        private OutlierType() { }

        public int Id => 83;
        public string Name => "Outlier Type";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"D", "Outlier days"},
            {"C", "Outlier cost"}
        };
    }
}
