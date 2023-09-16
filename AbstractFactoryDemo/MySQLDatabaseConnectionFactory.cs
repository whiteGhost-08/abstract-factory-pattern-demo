using MySql.Data.MySqlClient;
using System.Data;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// Concrete factory for creating MySQL database connections.
    /// </summary>
    public class MySQLDatabaseConnectionFactory : IDatabaseConnectionFactory
    {
        /// <summary>
        /// Creates a new MySQL database connection.
        /// </summary>
        /// <returns>An instance of the MySQL database connection.</returns>
        public IDbConnection CreateConnection()
        {
            return new MySqlConnection();
        }
    }
}
