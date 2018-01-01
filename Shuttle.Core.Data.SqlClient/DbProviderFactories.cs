using System.Data.Common;
using System.Data.SqlClient;
using Shuttle.Core.Contract;

namespace Shuttle.Core.Data.SqlClient
{
    public class DbProviderFactories : IDbProviderFactories
    {
        public DbProviderFactory GetFactory(string providerName)
        {
            Guard.AgainstNullOrEmptyString(providerName, nameof(providerName));

            return new SqlProviderFactory();
        }

        private class SqlProviderFactory : DbProviderFactory
        {
            public override DbConnection CreateConnection()
            {
                return new SqlConnection();
            }
        }
    }
}