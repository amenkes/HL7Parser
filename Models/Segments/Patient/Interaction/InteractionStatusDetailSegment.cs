using HL7Data.Contracts.Segments.Patient.Interaction;
using HL7Data.Models.Base;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Patient.Interaction
{
    public class InteractionStatusDetailSegment : BaseSegment, IInteractionStatusDetailSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.ISD;
    }
}