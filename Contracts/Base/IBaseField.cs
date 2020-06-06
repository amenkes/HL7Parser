using HL7Data.Models.Types;

namespace HL7Data.Contracts.Base
{
    public interface IBaseField : IElement
    {
        ElementDataType DataType { get; }
    }
}