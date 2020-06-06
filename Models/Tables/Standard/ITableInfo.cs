using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public interface ITableInfo
    {
        int Id { get; }
        string Name { get; }
        IDictionary<string, string> Values { get; }
    }
}