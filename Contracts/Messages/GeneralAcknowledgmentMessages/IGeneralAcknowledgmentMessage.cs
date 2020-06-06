namespace HL7Data.Contracts.Messages.GeneralAcknowledgmentMessages
{
    public interface IGeneralAcknowledgmentMessage : IBaseGeneralAcknowledgmentMessage
    {
#if TODO
        ICollection<ISoftwareSegment> SoftwareSegment { get; set; }
        IMessageAcknowledgement MessageAcknowledgement { get; set; }
        ICollection<IErrorSegment> Errors { get; set; }
#endif
    }
}