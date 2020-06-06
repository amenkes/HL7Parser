using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class CheckDigitScheme : ITableInfo
    {
        private static ITableInfo InstanceData => new CheckDigitScheme();
        public static ITableInfo Instance => InstanceData;
        private CheckDigitScheme() { }

        public int Id => 61;
        public string Name => "Check Digit Scheme";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"BCV", "Bank Card Validation Number"},
            {"NPI", "Check digit algorithm in the US National Provider Identifier"},
            {"ISO", "ISO 7064: 1983"},
            {"M10", "Mod 10 algorithm"},
            {"M11", "Mod 11 algorithm"}
        };
    }
}