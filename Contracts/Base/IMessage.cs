using System.Collections.Generic;
using HL7Data.Models.Types;

namespace HL7Data.Contracts.Base
{
    public interface IMessage : ISegment
    {
        HL7MessageType MessageType { get; }
        IList<ISegment> Segments { get; set; }
        TriggerEventTypes TriggerEventType { get; }
    }
}