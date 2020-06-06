using System.Collections.Generic;

namespace HL7Data.Models.Tables.Standard
{
    public sealed class ValueCode : ITableInfo
    {
        private static ITableInfo InstanceData => new ValueCode();
        public static ITableInfo Instance => InstanceData;
        private ValueCode() { }

        public int Id  => 153;
        public string Name  => "Value Codecls";
        public IDictionary<string, string> Values => new Dictionary<string, string>
        {

        };
    }
}

