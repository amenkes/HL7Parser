namespace HL7Data.Contracts.Base
{
    public interface IBaseMessage : IMessage
    {
        string Subtype { get; }
    }
}