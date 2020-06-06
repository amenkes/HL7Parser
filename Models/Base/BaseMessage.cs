using HL7Data.Contracts.Base;
using System.Collections.Generic;
using HL7Data.Models.Types;

namespace HL7Data.Models.Base
{
    public abstract class BaseMessage : BaseSegment, IBaseMessage
    {
        public virtual HL7MessageType MessageType => HL7MessageType.Unknown;

        public virtual TriggerEventTypes TriggerEventType => TriggerEventTypes.Unknown;

        public virtual string Subtype => TriggerEventType.ToString();

        public IList<ISegment> Segments { get; set; } = new List<ISegment>();
    }
}