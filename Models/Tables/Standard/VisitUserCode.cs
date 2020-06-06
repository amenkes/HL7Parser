using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class VisitUserCode : ITableInfo
    {
        private static ITableInfo InstanceData => new VisitUserCode();
        public static ITableInfo Instance => InstanceData;
        private VisitUserCode() { }

        public int Id  => 130;
        public string Name  => "Visit User Code";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"TE", "Teaching"},
            {"HO", "Home"},
            {"MO", "Mobile Unit"},
            {"PH", "Phone"}
        };
    }
}

