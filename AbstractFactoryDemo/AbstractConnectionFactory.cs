namespace AbstractFactoryDemo
{
    /// <summary>
    /// Abstract factory class that provides a method to get a specific database connection factory.
    /// </summary>
    public abstract class AbstractConnectionFactory
    {
        /// <summary>
        /// Factory method to get a database connection factory based on the database type.
        /// </summary>
        /// <param name="databaseType">The type of the database (e.g., "mysql", "postgresql").</param>
        /// <returns>An instance of the database connection factory.</returns>
        /// <remarks>
        /// Throws an exception if the specified database type is invalid.
        /// </remarks>
        public static IDatabaseConnectionFactory GetFactory(string databaseType)
        {
            return databaseType switch
            {
                "mysql" => new MySQLDatabaseConnectionFactory(),
                "postgresql" => new PostgreSQLDatabaseConnectionFactory(),
                _ => throw new Exception("Invalid database type"),
            };
        }
    }
}
