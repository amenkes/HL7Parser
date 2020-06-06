using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class OrderStatus : ITableInfo
    {
        private static ITableInfo InstanceData => new OrderStatus();
        public static ITableInfo Instance => InstanceData;
        private OrderStatus() { }

        public int Id => 38;
        public string Name => "Order Status";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"A", "Some, but not all, results available"},
            {"CA", "Order was canceled"},
            {"CM", "Order is completed"},
            {"DC", "Order was discontinued"},
            {"ER", "Error, order not found"},
            {"HD", "Order is on hold"},
            {"IP", "In process, unspecified"},
            {"RP", "Order has been replaced"},
            {"SC", "In process, scheduled"}
        };
    }
}
