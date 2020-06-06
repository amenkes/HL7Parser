using HL7Data.Contracts.Factory;

// ReSharper disable StaticMemberInGenericType
// ReSharper disable PossibleMultipleWriteAccessInDoubleCheckLocking

namespace HL7Data.Factory.Base
{
    public abstract class BaseFactory<TFactory> : IFactory where TFactory : class, IFactory, new()
    {
        private static TFactory _factory;
        private static readonly object SyncRoot = new object();

        public static TFactory Instance
        {
            get
            {
                if (_factory != null) return _factory;
                lock (SyncRoot)
                {
                    if (_factory == null)
                        _factory = new TFactory();
                }
                return _factory;
            }
        }
    }
}
