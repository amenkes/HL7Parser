using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IProcessingType : IBaseField
    {
        string ProcessingId { get; }
        string ProcessingMode { get; }
    }
}