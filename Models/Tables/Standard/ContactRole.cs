using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class ContactRole : ITableInfo
    {
        private static ITableInfo InstanceData => new ContactRole();
        public static ITableInfo Instance => InstanceData;
        private ContactRole() { }

        public int Id  => 131;
        public string Name  => "Contact Role";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"E", "Employer"},
            {"C", "Emergency Contact"},
            {"F", "Federal Agency"},
            {"I", "Insurance Company"},
            {"N", "Next-of-Kin"},
            {"S", "State Agency"},
            {"O", "Other"},
            {"U", "Unknown"}
        };
    }
}

