using HL7Data.Contracts.Segments.Study;
using HL7Data.Models.Base;
using System;
using HL7Data.Models.Types;

namespace HL7Data.Models.Segments.Study
{
    [Obsolete]
    public class UnsolicitedSelectionSegment : BaseSegment, IUnsolicitedSelectionSegment
    {
        public override SegmentTypes SegmentType => SegmentTypes.URS;
    }
}