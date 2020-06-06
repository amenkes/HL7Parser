using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IChargeCodeAndDate : IBaseField
    {
        string InvocationEvent { get; set; }
        IDateTime DateTime { get; set; }
    }
}