using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class RoomType : ITableInfo
    {
        private static ITableInfo InstanceData => new RoomType();
        public static ITableInfo Instance => InstanceData;
        private RoomType() { }

        public int Id  => 145;
        public string Name  => "Room Type";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"PRI", "Private room"},
            {"2PRI", "Second private room"},
            {"SPR", "Semi-private room"},
            {"2SPR", "Second semi-private room"},
            {"ICU", "Intensive care unit"},
            {"2ICU", "Second intensive care unit"}
        };
    }
}

