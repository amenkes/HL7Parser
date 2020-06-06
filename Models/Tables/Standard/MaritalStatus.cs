using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class MaritalStatus : ITableInfo
    {
        private static ITableInfo InstanceData => new MaritalStatus();
        public static ITableInfo Instance => InstanceData;
        private MaritalStatus() { }

        public int Id => 2;
        public string Name => "Marital Status";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"A", "Separated"},
            {"D", "Divorced"},
            {"M", "Married"},
            {"S", "Single"},
            {"W", "Widowed"},
            {"C", "Common law"},
            {"G", "Living together"},
            {"P", "Domestic partner"},
            {"R", "Registered domestic partner"},
            {"E", "Legally Separated"},
            {"N", "Annulled"},
            {"I", "Interlocutory"},
            {"B", "Unmarried"},
            {"U", "Unknown"},
            {"O", "Other"},
            {"T", "Unreported"}
        };
    }
}
