using HL7Data.Contracts.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Base
{
    public abstract class BaseField : BaseElement, IBaseField
    {
        public override string Prefix => DataType.ToString();
        public virtual ElementDataType DataType => ElementDataType.None;
    }
}