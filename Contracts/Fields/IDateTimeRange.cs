using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IDateTimeRange : IBaseField
    {
        IDateTime EndDateTime { get; }
        IDateTime StartDateTime { get; }
    }
}