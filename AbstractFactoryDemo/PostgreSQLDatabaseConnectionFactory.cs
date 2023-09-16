using Npgsql;
using System.Data;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// Concrete factory for creating PostgreSQL database connections.
    /// </summary>
    public class PostgreSQLDatabaseConnectionFactory : IDatabaseConnectionFactory
    {
        /// <summary>
        /// Creates a new PostgreSQL database connection.
        /// </summary>
        /// <returns>An instance of the PostgreSQL database connection.</returns>
        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection();
        }
    }
}
