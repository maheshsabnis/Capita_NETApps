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
	- OOPs
		- Data Abstraction
		- Behavior Encapsulation aka Methods those are encapsulating various Operations
			- A Method can have different Behavior based on
				- Object Invoking it
					- Overriding of Methods with Dynamic or Runtime Polymorphism  
				- Input Parameters, Method Overloading
					- Type of Input Parameters
					- Length of Input Parameters
					- Order of Input Parameters 
					 
		- Derivation aka Inheritence
		- Sealed Class
			-  Class which Cannot be inherited
			- C# (3.0+) Extension Methods
				- A Mechanism of extending a class w/o deriving from it
				- This is useful when third-party systems nbeeds to be extended w/o any code updates
				- This offers an object consistency w/o creting new classes and their instances
			- Rules for Extension Methods
				- The class that declared an extension method MUST be static (Thred Safe)
				- The method MUST be static
				- The First Parameter of this method MUST be 'this' referred reference of the 'class OR interface' for which the method will be uses as an extension method
````csharp
 internal static class StringExtensions
    {
        public static int GetLength(this string str)
        { 
            return str.Length;
        }

        public static string ChangeCase(this string str, char c)
        { 
            if(c == 'l' || c == 'L') return str.ToLower();
            if(c == 'u' || c == 'U') return str.ToUpper();
            return str;
        }

        public static int GetWhiteSpaces(this string str)
        {
            int whiteSpaces = 0;
            foreach(char c in str) 
            {
                if(Char.IsWhiteSpace(c))
                    whiteSpaces++;
            }
            return whiteSpaces;
        }
    }

````
	- Generics
		- TypeSafe Approach of Creating Data Structutr in .NET
		- We define it only once and use it for different .NET Types (Including Custom Types)
		- The Runtime will create and maintain seperate Binry copies for these types in memory
		- System.Collections.Generic Namespace
		- Custom Generic Class
		- Generic COnstraints
			- Guidelkine to restrict the type of T, a generic parameter for performing operations on it
	- Delegate and Event
		- A Delegate is a .NET Type that is used to invoke a method wit its Reference
			- The Signeture of a method MUST match with the Signeture of the delegate
			- The delegate is always declared at namespace level
				- the 'delegate' a keyword
			- Used for 'Asynchronous call and execution of the method'
			- C# 2.0+  Onwards changes in delegate
				- Anonymous Method aka a method w/o name
					- The delegate abstract the implementation in it
					- Use the Anonymous Method for Utility (or highly reusable logic execution)
						- Introduced for 'Language Integrated Query (LINQ), C# 3.0'
				- C# 3.0
					- The Direct Implementation passed to the delegate will be evaluated as 'An Epression' in binary form known as 'Lambda Expression' 
			- Used for Declaring an 'Event'
				- An Event is a Spcial Delegate that is raised on condition
				- The Event is declared using delegate and the delegate is responsible to invoke a method that will be exeuted when an event is raised
				- A delegate that is used to declare an event must have a return type as 'void' 
````csharp
		- List<T>, Stach<T>, Queue<T>, LinkedList<T>
		- KeyValuePair<K,V>, Dictionary<K,V>
````
		- We can have
			- Generic class, Interface, method, event, delegate, variable

		- Strategies of passing Parameters to  methods in .NET
			- By Value
				- In C# by defualt method accepts all primptive type as 'by value' as inpput parameter where as the class types as passed as 'by ref' 
			- The 'ref'
				- pass value type by 'ref' using the 'ref' keyword
				- the ref type variable MUST be initialized before passing to a method 
			- The 'out'
				- Same like 'ref' but we MUST not intialize the varibale before passing to method, instead the method MUST set value for 'out' parameter
				- Generaly we use this for returning more that one value from the method w/o the return statement
			- The 'params'
				- Used to pass variable number of parameters to a method
- USes Cases for Manipulation of Collections as well as Handling various logical operations
	- Utilizing available cores of Production Server (At Hardware Level) 
		- Threads
			- System.Threading
				- Thread
					- Worker Thread to execute an Operation (method) on it 
						- File System Access
						- Database Access
						- Network Resources
				- Monitor, Synchronization
				- Mutext, Synchronization 
		- Memory Management
			- Garbage Collector aka GC class, System.GC
			- Background Thread for GC as well as Concurrent GC with Asynchronous Memory Mgmt
		- Large Collection Processing?
			- foreach..loop / for..loop / while..loop	
				- Synchronous and Controlled by a Single Thread hence they process the collection sequentially	
	- .NET Framework 4.0+ and Continue in .NET Core with .NET 5/6/7/8
		- Task Parallel Library (TPL) , .NET Frwk 4.0
			- System.Thread.Tasks Namespace
				- Parallel class
					- Fully-Automated operation class for Implicitly creating threads, delegating work on it, scheduling it, and releasing it  
					- Methods
						- Invoke()
							- An array of Delegates where each delegate will created  a thread to execute an operation on it
								- The 'Action' delegate
						- For()
							- Used to process a collection by creating threads internally
						- ForEach()
							- Same as For(), only the difference is its starts from 0th operations and keep allocating radomly for each record in the collection
				- Task, vaey important class
					- A unit of Async operation
					- A Task is a Thread
					- BY default an Async Execution
					- Task and ````csharp Task<T> ````
						- Task, operation allocated on this will not return value
						- T is return value type from the operation allocated on Task
					- TaskFactory, a factory to execute operation inside the Task
						- Task.Factory.StartNew(OPERATION-TO-BE-EXECUTED) 
					- Methods
						- Run()
						- Wait(), wait until the task is not completed
						- WaitAll(), must wait for all tasks to comlplete 
						- ContinueWith()
							- Continue from One Task to Other Task
							- Result returned by Previous Task can be send as Input to Other Task
								- e.g.
									- Task 1: Will Calculate Gross Salary
									- Task 2: Will accept Gross Salary and Calculate TDS
									- Task 3: Will Accept the TDS and then based on Invetsment genretae return calculatrion
					- .NET Frwk 4.5 + and Continue to .NET Core and .NET 5/6/7/8
						- The Default Async Methods
							- FileReadAsync() , FileWriteAsync(), etc.
							- ExecureReaderAsync(), ExecuteNonQuery(), etc.
							- UploadAsync(), DownloadAsync(), etc.
						- Each async method returns a Task Object
						- C# 4.5 +
							- The 'async' and 'await'
								- The async is used for method that returns Task Object
								- The await is used to infor the runtime that the current method call will be executing asynchornosuly so wait for teh completion of it
				   - System.Collections.Concurrent
						- Concurrent Collection, collection those are accessible across threads w/o any locking
							- ConcurrentBag
							- ConcurrentDictionary
							- ConcurrentQueue
							- ConcurrentStack
	- In C# for exception use the 'Exception' class
		- try{....}catch(Exception ex){.....} block 
							
# WebApps	for Building REST APIs