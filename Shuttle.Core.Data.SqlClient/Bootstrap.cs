using Shuttle.Core.Container;
using Shuttle.Core.Contract;

namespace Shuttle.Core.Data.SqlClient
{
    public class Bootstrap : IComponentRegistryBootstrap
    {
        public void Register(IComponentRegistry registry)
        {
            Guard.AgainstNull(registry, nameof(registry));

            registry.AttemptRegister<IDbProviderFactories, DbProviderFactories>();
        }
    }
}