namespace HL7Data.Contracts.Fields
{
    public interface ICodedElementWithFormattedValues : ICodedElement
    {
        string AlternateFormattedText { get; }
        string FormattedText { get; }
    }
}