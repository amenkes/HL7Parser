using System.Collections.Generic;
using HL7Data.Models.Tables.Standard;

namespace HL7Data.Models.Tables.Base
{
    public abstract class BaseTableInfo : ITableInfo
    {
        protected static ITableInfo ProtectedData = new TableInfo();
        public static ITableInfo Instance => ProtectedData;

        private BaseTableInfo(){}

        public virtual int Id => -1;
        public virtual string Name => string.Empty;
        public virtual IDictionary<string, string> Values => null;
    }
}
