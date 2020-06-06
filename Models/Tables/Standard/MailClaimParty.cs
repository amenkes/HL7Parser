using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class MailClaimParty : ITableInfo
    {
        private static ITableInfo InstanceData => new MailClaimParty();
        public static ITableInfo Instance => InstanceData;
        private MailClaimParty() { }

        public int Id  => 137;
        public string Name  => "Mail Claim Party";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"E", "Employer"},
            {"G", "Guarantor"},
            {"I", "Insurance company"},
            {"O", "Other"},
            {"P", "Patient"}
        };
    }
}

