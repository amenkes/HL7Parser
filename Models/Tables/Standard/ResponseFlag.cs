using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class ResponseFlag : ITableInfo
    {
        private static ITableInfo InstanceData => new ResponseFlag();
        public static ITableInfo Instance => InstanceData;
        private ResponseFlag() { }

        public int Id => 121;
        public string Name => "Response Flag";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {
            {"E",   "Report exceptions only"},
            {"R",   "Same as E, also Replacement and Parent-Child"},
            {"D",   "Same as R, also other associated segments"},
            {"F",   "Same as D, plus confirmations explicitly"},
            {"N",   "Only the MSA segment is returned"}

        };
    }
}
