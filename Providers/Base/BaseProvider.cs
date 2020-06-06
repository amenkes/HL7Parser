using System;
using System.Collections.Generic;
using HL7Data.Contracts.Generics;
using HL7Data.Contracts.Providers;
using HL7Data.Models.Packages;

namespace HL7Data.Providers.Base
{
    public abstract class BaseProvider : IProvider
    {
        public IGenericPackage GenericPackage { get; set; }
        protected Package StandardPackage { get; set; }
        public virtual IDictionary<Type, Type> ProviderOverrides { get; } = new Dictionary<Type, Type>();
        public Package Package { get; set; } //TODO
    }
}
