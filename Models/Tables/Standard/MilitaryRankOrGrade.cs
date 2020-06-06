using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class MilitaryRankOrGrade : ITableInfo
    {
        private static ITableInfo InstanceData => new MilitaryRankOrGrade();
        public static ITableInfo Instance => InstanceData;
        private MilitaryRankOrGrade() { }

        public int Id  => 141;
        public string Name  => "Military Rank or Grade";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"E1... E9", "Enlisted"},
            {"O1 ... O9", "Officers"},
            {"W1 ... W4", "Warrant Officers"}
        };
    }
}

