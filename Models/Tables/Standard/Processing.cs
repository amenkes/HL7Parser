using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class Processing : ITableInfo
    {
        private static ITableInfo InstanceData => new Processing();
        public static ITableInfo Instance => InstanceData;
        private Processing() { }

        public int Id => 103;
        public string Name => "Processing ID";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"D", "Debugging"},
            {"P", "Production"},
            {"T", "Training"}
        };
    }
}
