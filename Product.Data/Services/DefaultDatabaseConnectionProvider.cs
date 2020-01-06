using Npgsql;
using ProductMicroservice.Data.Interface;
using System.Data;
using System.Data.SqlClient;

namespace ProductMicroservice.Data.Services
{
    public class DefaultDatabaseConnectionProvider : IDatabaseConnnectionProvider
    {
        private readonly IConnectionStringProvider _connectionStringProvider;
        //inject the connectionstring into your database connection
        public DefaultDatabaseConnectionProvider(IConnectionStringProvider connectionStringProvider)
        {
            _connectionStringProvider = connectionStringProvider;
        }

        //implement the interface to return the connection
        public IDbConnection GetDbConnection()
        {
            return new NpgsqlConnection(_connectionStringProvider.GetConnectionString());
        }
    }
}
