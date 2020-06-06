using System.Collections.Generic;
using HL7Data.Models.Tables.Standard;

namespace HL7Data.Models.Tables.Base
{
    public class TableInfo : ITableInfo
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public IDictionary<string, string> Values { get; protected set; }
    }
}
