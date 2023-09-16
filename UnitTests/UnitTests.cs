using AbstractFactoryDemo;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for the AbstractConnectionFactory class.
    /// </summary>
    [TestClass]
    public class AbstractConnectionFactoryTests
    {
        /// <summary>
        /// Ensures that GetFactory returns the correct factory for the specified database type.
        /// </summary>
        [TestMethod]
        public void GetFactory_ShouldReturnFactoryForSpecifiedDatabaseType()
        {
            // Arrange
            IDatabaseConnectionFactory factory = AbstractConnectionFactory.GetFactory("mysql"); // Get connection factory for MySQL database
            // Act
            
            // Assert
            Assert.That(factory, Is.InstanceOf<MySQLDatabaseConnectionFactory>());
        }
        /// <summary>
        /// Ensures that GetFactory throws an exception for an invalid database type.
        /// </summary>
        [TestMethod]
        public void GetFactory_ShouldThrowExceptionForInvalidDatabaseType()
        {
            // Arrange

            // Act
            Exception? exception = Assert.Throws<Exception>( () => AbstractConnectionFactory.GetFactory( "invalid" ) );

            // Assert
            Assert.AreEqual("Invalid database type", exception?.Message);
        }
    }
}
