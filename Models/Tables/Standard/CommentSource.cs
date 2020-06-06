using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class CommentSource : ITableInfo
    {
        private static ITableInfo InstanceData => new CommentSource();
        public static ITableInfo Instance => InstanceData;
        private CommentSource() { }

        public int Id => 105;
        public string Name => "Source of Comment";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"L", "Ancillary (filler) department is source of comment"},
            {"P", "Orderer (placer) is source of comment"},
            {"O", "Other system is source of comment"}
        };
    }
}
