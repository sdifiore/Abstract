https://youtu.be/YM_Xl77bVWw?si=d8AAhmJPdMsVHi4s

WHAT ARE DESIGN PATTERNS?

	 - A pattern addresses a common problem
	 - It is a template or guide
				- Not a final design
		- Doesn't describe classes
				- Describes relationships and interactions between classes
		- Not architectural patterns
				- Smaller in scope

WHAT ARE DESIGN PATTERNS?

		- Four elements:
			- Pattern Name
			- Problem Addressed
			- Solution
			- Consequences

DESIGN PATTERNS EXAMPLE

		- Problem
				- Support multiple database types
		- Pattern Name
				- Abstract Factory
		- Solution
				- Define an abstract database class
				- Use a factory class to create an instance that supports current database type

GANG OF FOUR

		 - Classic Text
		- Design Patterns: Elements of Reusable Object-Oriented Software (1995)
				- Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides
						- http://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612/
		- Describes 23 patterns


ABSTRACT FACTORY PATTERN - PROBLEMS

		- App needs to support multiple database types
				- SQL Server, Oracle, MySQL
				- Isolate database type from application
		- Measurement data comes from multiple sources
				- Serial port, Ethernet, device driver
		- Need to create different report types
				- PDF, Word doc, etc.

BUILDER PATTERN - PROBLEMS

		- App needs to construct multiple type classes
				- These classes have complicated construction methods
		- Database
				- Connection string, Command type, timeout
		- Measurement data sources
				- Serial port: port number, baud rate, parity, etc.
				- Ethernet: IP address, port, timeout, etc.
		- Isolate construction process from application

BUILDER PATTERN

		- Separate object construction from its representation
		- Same construction process can create different representations
		- Often used with Abstract Factory pattern
		- Builder Interface or abstract class
				- Generalized object construction interface
				- Provides methods for each object construction step
		- Create Builder classes that implement builder interface for each object type

		- Director class
				- Uses builder interface to construct object
				- Knows the order of construction steps

		BUILDER PATTERN EXAMPLE
		- Construct Database class
				- SQL Server and OleDB
		- Create Connection, Command objects
		- Set Command parameters

		BUILDER PATTERN EXAMPLE CLASSES
		- Database abstract factory classes
				- Abstract Database class
				- SqlServerDatabase class
						- Inherits from Database class
				- OleDbDatabase class
						- Inherits from Database class

		BUILDER PATTERN EXAMPLE CLASSES
		- IDatabaseBuilder interface
				- BuildConnection method
				- BuildCommand method
				- SetSettings method
				- Database property
		- SqlServerDatabaseBuilder and OleDbDatabaseBuilder classes
				- Implement IDatabaseBuilder

