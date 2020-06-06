namespace HL7Data.Contracts.Generics
{
    public interface IGenericMessage : IGenericElement<IGenericMessage, IGenericSegment, IGenericPackage>
    {
        IGenericMessageHeader GenericMessageHeader { get; }
    }
}