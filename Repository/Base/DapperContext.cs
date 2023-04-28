using Npgsql;
using System.Data;

namespace Order.Repository.Base
{
    public class DapperContext : IDapperContext
    {
        private readonly string _connectionString;
        public DapperContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("OrderDBConn");
        }

        public IDbConnection CreateConnection() => new NpgsqlConnection(_connectionString);
    }
}
