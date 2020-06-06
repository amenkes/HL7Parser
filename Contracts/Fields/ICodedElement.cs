using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface ICodedElement : IBaseField
    {
        string AlternateIdentifier { get; }
        string AlternateText { get; }
        string AlternateCodingSystemName { get; }
        string CodingSystemName { get; }
        string Identifier { get; }
        string Text { get; }
    }
}