using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class TypeOfAgreement : ITableInfo
    {
        private static ITableInfo InstanceData => new TypeOfAgreement();
        public static ITableInfo Instance => InstanceData;
        private TypeOfAgreement() { }

        public int Id => 98;
        public string Name => "Type of Agreement";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"S", "Standard"},
            {"U", "Unified"},
            {"M", "Maternity"}
        };
    }
}
