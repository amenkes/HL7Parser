using System.Collections.Generic;

namespace HL7Data.Contracts.Base
{
    public interface IComponent
    {
        ISubcomponent FirstSubcomponent { get; }
        string Source { get; set; }

        IList<ISubcomponent> Subcomponents { get; }
        //IGenericField Parent { get; set; }
    }
}