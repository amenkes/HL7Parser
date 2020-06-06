using System;
using System.Collections.Generic;
using HL7Data.Contracts.Generics;
using HL7Data.Models.Packages;

namespace HL7Data.Contracts.Providers
{
    public interface IProvider
    {
        IGenericPackage GenericPackage { get; }
        Package Package { get; }
        IDictionary<Type, Type> ProviderOverrides { get; }
    }
}