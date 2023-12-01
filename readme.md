# .NET Apps

# C# Programming Language

- Types
	- System.Type, the highest type
		- Schema, properties and methods (behaviors)
		- Value, the data stored in type 
		- Memory Requirement
	- Namespaces
		- Group of Classes those are targtted to a specific set of behavior
			- The 'System' the highest level namespace 
			- System.IO, for Stream or File Access
			- System.Data, for data access
			- System.Net, for network
			- ..... and many more
	- Data Types
		- Value and Reference

Category		KeyWord				Type				Size (in bytes)
		
Numeric			byte				System.Byte			1	
				short / ushort		System.Int16		2
				int	/ uint			System.Int32		4
				long / ulong		System.Int64		8
				float				System.Single		4
				double				System.Double		8
				decimal				System.Decimal		16

Characters		char				System.Char			2
				string				System.String		Length+2, max upto 2 GB

Boolean			bool				System.Boolean		1

Date			date				Syatem.Date			10


		- References
			- The 'Object'
				- System.Object, declared using the 'object' keyword
			- The Class, Interface, Delegate, Events, Tuple (C# 7.0+), Record (C# 10 +) 
			- Specialized Data Type
				- Collections
		- Conversions and Casting
			- Convertions, at compile time, the compiler already knows the LHS and RHS of statement or expression, this may not have possiblity of Runtime Exception.
				- The 'Convert' class under the 'System' Namespace
			- Casting, occures are Runtime, the possiblity of Runtime Exception is more	
				- The Runtime MUST be provided with the accurate expression values
			- Boxing and UnBoxing
				- Value Type to reference type conversion is, Boxing
					- Store a Value and its Type in the Object, means in a object we have the first entry of Data Type and second entry for the actual data
				- Extracting a Value type from the Reference Type (Object) in boxing
					- The knowledge of the Data Type Stored into Object MUST be known
	- Standard Practices
		- Use Nullable reference types
		- Initialize all the declarations (please do not dependant on default initial value)
		- Avoid over use of Boxing and UnBoxing
	- Custom Types
		- Object Oriented Programming 
	- Standard Classes 
		- Array and String
	- Custom Types
		- OOPs
			- Practices of OOPs aka Applied OOPs
			- Generics
		- Interfaces
		- Event and Delegates 

- Input and Output Statements
	- Standard Class for Interactivity 

- Mandatory Resources in .NET App
	- Program.cs
		- An Enrty Point with an implicit 'Program' class and a 'static Manin()' method
	- The Project File, contains following information
		- Target Runtime and Platform
		- Internal Standard dependencies and External Dependencies 
# App Development
- Define Core Objects
	- Entities
		- Objects that holds the mandatory data for the application
			- e.g.
				- Product, Customer, Order, Manufacturer, Dispatch, etc. 
			- C# Language Support
				- Class with 
					- Data Mambers aka Fields
					- Properties aka Smart / Intelligent Fields
	- Logic / Domain / Appliation Layer
		- Business Workflows
			- Read and Write Operation using Entities 
			- C# Language Support
				- Methods
					- Read and Write
						- Iterative Approach aka loops
						- Condtional Statements
						- Object Querying to Read Data 
				- Notifications for the "Work-Done"
					- Delegate and Event 
- Data Persistence Layer aka Infrastaructure
	- Infrastructure for Database Calls
		- Object Relational Mapping (ORM)
			- EntityFrameworkCore 
	- In-Memory Data Store 
		- Collections 
			- Object Store Collections, where each entry is stored as Object, Boxing and UnBoxing
			- Generics (Recommended)
- With OOPs Concepts
	- Access Specifiers
		- Private, within class
		- Protected, within class and in its derived class
		- Public, Accessible everywhere
		- Internal, accessible across all classes within the assembly, default access specifier for class
		- Protected Internal, Same as Internal but additionally accessible in the derived class of other assembly
			- E.g.
				- Asm1 has Base class named MyBase, the Asm2 has the derive class MyDerive that is derived from the MyBase from Asm1 
	- Access Modifiers
		- Abstract class and Method
			- Class MUST be derived and method MUST be overriden using method in derived class  
			- Abstract method cannot have an implementation
			- Keyword: abstract 
		- Sealed class and Method
			- Class cannot be derived and method cannot be overriden 
			- Keyword: sealed
		- Virtual Method
			- Can have a default implementation
			- Keyword: virtual 
		- Overriding the Virtual and Abstract Method
			- Keyword: override 
		- Static 
			- Class and Method 
- OOPs Implementation for App Development
	- Create an Entity class, class with Public Read/Write or ReadOnly Properties
		- AKA DTO AKA Value Object (VO), AKA Core Object 
	- Create a Logic Class that will have following
		- A Data Store using In-Memory Collection
			- The .NET Collection Classes
			- System.Collections NAmespace
				- ArrayList, Queue, SortedList, etc.
				- Each Enrty in Collection is Stored as Object
		- (Optionally) Call to Data Accces Infra Layer
		- Domain Logic and Rule Set to Validate Input
		- Perform Read/Write Operations
			- The Input or Output parameter MUST be the Entity Class for these methods 
- Use the Inheritence Properly to reduce /  eliminate the repeatation and focus to a specific logic implementation for the object
	- The Core Object and Logic Object should be Open for Extension (Derivation) and Close for Modification, a Open-Close-Principal (OCP) for App Development
	- Define the Abstract Logic Funcationalities
		- The 'abstract' class that will provide a fair idea of logic implementation
			- Mandatory and foundational implementation, a Virtual Method
			- An abstract method
				- They do nbit have any implementation
				- The derived class MUST Override them
	- The Derivation provides an  'Is-a' Relationship across Objects
		- Only One Base class 
			- One base class can have multiple derived classes, Hierarchical Inheritence
			- If a classs have only one derived class the it is Single Inheritence
			- If a derive class itself act as a base for for further derivation then it is MultiLevel Inheritence
# Web Apps for Building REST APIs