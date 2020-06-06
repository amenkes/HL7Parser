using HL7Data.Contracts.Generics;
using System.Collections.Generic;

namespace HL7Data.Contracts.Base
{
    public interface IPackage : IElement
    {
        IGroup FirstGroup { get; }
        IGenericPackage GenericPackage { get; }
        IList<IGroup> Groups { get; }
        IList<IMessage> Messages { get; }
    }
}