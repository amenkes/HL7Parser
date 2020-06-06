using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface ICompositeQuantityWithUnits : IBaseField
    {
        decimal Quantity { get; set; }
        string Units { get; set; }
    }
}