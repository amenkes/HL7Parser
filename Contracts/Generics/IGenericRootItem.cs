using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Generics
{
    public interface IGenericRootItem
    {
        IElement ReferenceElement { get; set; }
        IParsingInfo ParsingInfo { get; set; }
        string SeparatorCharacter { get; }
        string Source { get; set; }
        string Value { get; }
    }
}