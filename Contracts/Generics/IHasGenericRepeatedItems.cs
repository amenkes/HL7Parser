namespace HL7Data.Contracts.Generics
{
    public interface IHasGenericRepeatedItems
    {
        IGenericRepeatedItem GenericRepeatedItem { get; set; }
    }
}