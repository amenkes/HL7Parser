using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class ResultStatus : ITableInfo
    {
        private static ITableInfo InstanceData => new ResultStatus();
        public static ITableInfo Instance => InstanceData;
        private ResultStatus() { }

        public int Id  => 123;
        public string Name  => "Result Status";

        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"O", "Order received; specimen not yet received"},
            {"I", "No results available; specimen received, procedure incomplete"},
            {"S", "No results available; procedure scheduled, but not done"},
            {"A", "Some, but not all, results available"},
            {"P", "Preliminary: A verified early result is available, final results not yet obtained"},
            {"C", "Correction to results"},
            {"R", "Results stored; not yet verified"},
            {"F", "Final results; results stored and verified.  Can only be changed with a corrected result."},
            {"X", "No results available; Order canceled."},
            {"Y", "No order on record for this test.  (Used only on queries)"},
            {"Z", "No record of this patient. (Used only on queries)"}
        };
    }
}

