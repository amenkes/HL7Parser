using HL7Data.Contracts.Base;

namespace HL7Data.Contracts.Fields
{
    public interface IMessageAcknowledgement : IBaseField
    {
        string AcknowledgementCode { get; }
        string MessageControlId { get; }
        string TextMessage { get; }
        string ExpectedSequenceNumber { get; }
        string DelayedAcknowledgementType { get; }
        string ErrorCondition { get; }
    }
}