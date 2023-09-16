# abstract-factory-pattern-demo
This repository contains an example of the abstract factory design pattern. The pattern is implemented in four files:

* `AbstractConnectionFactory.cs`: This file contains the abstract `AbstractConnectionFactory` class, which provides a static method to get a concrete factory for the specified type of database.
* `IDatabaseConnectionFactory.cs`: This file contains the `IDatabaseConnectionFactory` interface, which defines a single method, `CreateConnection()`, which is used to create a database connection.
* `MySQLDatabaseConnectionFactory.cs`: This file contains the `MySQLDatabaseConnectionFactory` class, which is a concrete implementation of the `IDatabaseConnectionFactory` interface that creates connections to MySQL databases.
* `PostgreSQLDatabaseConnectionFactory.cs`: This file contains the `PostgreSQLDatabaseConnectionFactory` class, which is a concrete implementation of the `IDatabaseConnectionFactory` interface that creates connections to PostgreSQL databases.
![structure jpeg](https://github.com/whiteGhost-08/abstract-factory-pattern-demo/assets/83160894/d6e38e53-8b8e-4522-ab18-c961ee4a25ce)

The abstract factory pattern is used to create families of related objects without having to specify their concrete classes. This makes it easy to switch between different types of databases without having to modify the client code.

To use the abstract factory pattern, you would first call the `AbstractConnectionFactory.GetFactory()` method to get a concrete factory for the specified type of database. Then, you would call the `CreateConnection()` method on the factory to create a database connection.

For example, the following code shows how to create a database connection to a MySQL database:

```c#
var factory = AbstractConnectionFactory.GetFactory("mysql");
var connection = factory.CreateConnection();
```
You can then use the `connection` object to perform database operations.

The abstract factory pattern is a powerful tool that can be used to create families of related objects without having to specify their concrete classes. It is a fundamental pattern that is used in many popular software programs, including database libraries, web applications, and ERP systems.
