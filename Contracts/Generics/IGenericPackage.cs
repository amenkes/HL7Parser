namespace HL7Data.Contracts.Generics
{
    public interface IGenericPackage : IGenericElement<IGenericPackage, IGenericMessage, IGenericNoParent>
    {
        string Data { get; }
        bool IsMllp { get; }
    }
}