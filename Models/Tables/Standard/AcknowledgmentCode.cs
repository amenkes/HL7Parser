using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class AcknowledgmentCode : ITableInfo
    {
        private static ITableInfo InstanceData => new AcknowledgmentCode();
        public static ITableInfo Instance => InstanceData;
        private AcknowledgmentCode() { }

        public int Id => 8;
        public string Name => "AcknowledgmentCode";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"AA", "Original mode: Application Accept - Enhanced mode: Application acknowledgment: Accept"},
            {"AE", "Original mode: Application Error – Enhanced mode: Application acknowledgment: Error"},
            {"AR", "Original mode: Application Reject - Enhanced mode: Application acknowledgment: Reject"},
            {"CA", "Enhanced mode: Accept acknowledgment: Commit Accept"},
            {"CE", "Enhanced mode: Accept acknowledgment: Commit Error"},
            {"CR", "Enhanced mode: Accept acknowledgment: Commit Reject"}
        };
    }
}
