using HL7Data.Contracts.Generics;
using System.Collections.Generic;

namespace HL7Data.Contracts.Base
{
    public interface IGroup : IElement
    {
        IGroup FirstSubgroup { get; }
        IGenericSegment FirstSegment { get; }
        IList<IGroup> Groups { get; }

        IList<IGenericSegment> Segments { get; }
        //string Source { get; set; }
    }
}