using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class AdministrativeSex : ITableInfo
    {
        private static ITableInfo InstanceData => new AdministrativeSex();
        public static ITableInfo Instance => InstanceData;
        private AdministrativeSex(){}

        public int Id => 1;
        public string Name => "Administrative Sex";
        public IDictionary<string, string> Values  => new Dictionary<string, string>
        {
            {"F", "Female"},
            {"M", "Male"},
            {"O", "Other"},
            {"U", "Unknown"},
            {"A", "Ambiguous"},
            {"N", "Not applicable"}
        };
    }
}
