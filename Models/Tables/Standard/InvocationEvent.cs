using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class InvocationEvent : ITableInfo
    {
        private static ITableInfo InstanceData => new InvocationEvent();
        public static ITableInfo Instance => InstanceData;
        private InvocationEvent() { }

        public int Id => 100;
        public string Name => "Invocation event";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"D", "On discharge"},
            {"O", "On receipt of order"},
            {"R", "At time service is completed"},
            {"S", "At time service is started"},
            {"T", "At a designated date/time"}
        };
    }
}
