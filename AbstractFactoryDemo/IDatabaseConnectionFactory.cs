using System.Data;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// Interface for creating database connections.
    /// </summary>
    public interface IDatabaseConnectionFactory
    {
        /// <summary>
        /// Creates a new database connection.
        /// </summary>
        /// <returns>An instance of the database connection.</returns>
        IDbConnection CreateConnection();
    }
}
