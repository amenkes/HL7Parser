using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IEventDateTime : IBaseField
    {
        IDateTime EventDateTimestamp { get; set; }
        string DateTimeFormatted { get; }
        string Precision { get; }
    }
}