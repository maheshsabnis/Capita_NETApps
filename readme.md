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
	- Interface
		- A Type that contains method declartion
		- Method does nit have any access specifier, instaed each method is automatically set to the accepss specifier applied for interface
		- The class can implement one-or-more interfaces (NO Multiple Inheritence) but can be deribed from only one base class 
		- Rules
			- When a class implements interface all methods of interface MUST be implemented by class
			- Methods can be implemented implicitly or Explicitly
				- Implicit: Methods are owned by Class and Interface both 
				- Explict: Class only provides implementation but methods are always accessed using Interface reference
					- If class implements more that one interfaces and these interfaces has one or more methods with same name and signeture then implement interface explicitly 
	- C# 3.0+
		- Auto-Implemented Properties
		- Anonymous Mathods aka Lambda Expression
		- Object and Collection Initiliazer
		- Extension Methods
		- System.Collection.Enumerable class
			- All Extension Methods written for "IEnumerable interface" 
				- Select()
				- Where()
				- OrderBy(), GroupBy(), Jon(), etc.
		- Language Integrated Query (LINQ)
			- A Framework that provide a  mechanism to Query
				- Collections / Generic Collections ****** HEavily Used
					- LINQ to Objects aka OLinq
					- In-Memory Collection are handled like tables 
						- Used as a foundation for Object-relational-Mapping (ORM) e.g. EntityFramework and EntityFrameworkCore  
				- Xml document
					- LINQ to XML aka XLinq 
					- Used only when the XML is used but this is fastest way of reading and processing XML Documents 
				- Database Tables with Data Access Objects
					- LINQ to Database aka DLinq
						- LINQ to SQL
						- LINQ to DataSet (ADO.NET)
					- Pushed beh8ing because of   EntityFramework and EntityFrameworkCore  
			- Imperative and declarative
				- Imperative : Uses an Extension Method and Lambda Expression
					- e.g. Where, Select, etc.
				- Declarative : Use the Database Like Queries
					- Keywords like select, where, join, order, etc.
					- 
# WebApps for Building REST APIs

- Using Object Relational Mapping (ORM) using EntityFrameworkCore (EF Core)
	- Entity (C# Classes with Public Properties) are mapped with Database Table Columns for Read/Write Operations 
	- dotnet ef tool CLI
		- Run the following command from the Command Prompt / Terminal (Linux / Mac) 
			- dotnet tool install --global dotnet-ef	
	- Packages to use EF Core in Application
		- Microsoft.EntityFrameworkCore , the base package 
		- Microsoft.EntityFrameworkCore.Relational , the  package for Accessing Relational database
		- Microsoft.EntityFrameworkCore.SqlServer, for Accessing SQL Server database
		- Microsoft.EntityFrameworkCore.Design, for establishing Mapping between .NET App and Relation Servre database
		- Microsoft.EntityFrameworkCore.Tools, used for running dotnet ef CLI ommands for the .NET App
	- Install Package from CLI
		- Go to the Project Folder from Command Prompt and run the following command
			- dotnet add package [PACKAGE-NAME] -v [VERSION-NUMBER] 
			- dotnet add package Microsoft.EntityFrameworkCore -v 7.0.14
			- dotnet add package Microsoft.EntityFrameworkCore.Relational -v 7.0.14
			- dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 7.0.14
			- dotnet add package Microsoft.EntityFrameworkCore.Design -v 7.0.14
			- dotnet add package Microsoft.EntityFrameworkCore.Tools -v 7.0.14
		
		- dotnet restore
			- To install all packages mentioned in .csproj, the Project file
		- dotnet build
			- To build the project
		- dotnet run
			- To run the project
			- 
- Approaches of Using EF Core in application
	- Database First
		- Generate Entity Classes and Data Access Operation class from Already available database
			- used when the Database is Production Ready and no changes will be made in database
	- Code-First
		- If the app is developed from scratch and no database is planned already 
		- Create Entity Classe and Data Access Operation class using C#
		- Generate Database Migrations, the code-scripts for creating database and table and relationships across tables
		- Update the Database to generate database with tables in it 

- EF Core Object Model
	- DbContecxt class
		- Manage DB Connection
		- Manage Transactions from Application to Database
		- Manage Entity Classs Mapping with Database Table using DbSet class 
			- Defing Entity class to Database Table Mapping using public DbSet properties 
````csharp
				 public DbSet<Employee> Employees {get;set;} 
````
		
			- OnConfiguring() method
				- Defines Connectionstring to Database
			- OnModelMapping(ModelBuilder builder)
				- Method that contains code which specifies how the entity class and its properties are mapped with database table column  
					- e.g. Primary Key, Foreign Key, One-to-One, One-to-Many, Many-to-Many relationships 
					- This code is known as 'Fluent API'

	- ````csharp DbSet<T> ````
		- T is the name of Entity class that maps with table named T  
		- This represents a 'RecordSet' which has all rows for Read/Write purpose

- Stanndard pseduo code for using EF COre for CRUD Operations	
````csharp
 // Entity classs
 public class Employee {}

 // DbContext class is EmpDbContext

 EmpDbContext ctx = new EmpDbContext();
 
 // DbSet of Employee in EmpDbConmtext class is 'Employees'
  
  	

 // 1. To Read All Employees

 var emps = ctx.Employees.ToList();
 // if async read
  var emps = await ctx.Employees.ToListAsync();

 // 2. To Read Employee based on PK
 var emp = ctx.Employees.Find(EmpNo); // EmpNo is Primary Key
 // async
  var emp = await ctx.Employees.FindAsync(EmpNo);

  // 3. To Append New record in Employee
  // a. create an instnace of Employee entity and set its propety values
  Employee newemp = new Employee();
  newEmp.EmpNo = 100;

  // b. Add it in Employee DbSet
  ctx.Employees.Add(newEmp);
  // async
  await ctx.Employees.AddAsync(newEmp);
  // c. Commite Transaction
  ctx.SaveChanges();
  // async
  await ctx.SaveChangesAsync();

  // d. Adding Bulk Employees e.g. Employee Entity Array / List
  ctx.Employees.AddRange();
  // async
  await ctx.Employees.AddRangeAsync();

  // 4. To Update Record
  // a. Search Record Based on Primary Key (Refer No 2.)
  // b. Update its property values (Refere No 3.a.)
  // c. Commit Transaction (Refer No. 3.c)

  // 5. To Delete
  // a. Search Record Based on Primary Key (Refer No 2.)
  // b. Call remove Method on DbSet
  ctx.Employees.Remove(emp);
  // c. Commit Transaction (Refer No. 3.c)

````





- CLI Command for Database First Approach

	- dotnet ef dbcontext scaffold "[Database Connection String]" [Database-Provider-Package-Name] -o [Folder-Where-EntityClasses-DataAccessOperaion-Class-To-Be-Generated] -t [TABLE-NAME]
	
		- dbcontext: the instructoin given for executing database first
		- scaffold: An instruction to read database and table schema to generate entities 
		- Database Connection String:
			- If Using Windows Authentication
				- "Data Source=IP-Address-Of-Server / Name-Of-Server-Machine / . / localhost;Initial Catalog=[NAME-OF-THE-DATABASE];Integrated Security=SSPI" 
			- If using SQL Server Authentication
				- "Data Source=IP-Address-Of-Server / Name-Of-Server-Machine / . / localhost;Initial Catalog=[NAME-OF-THE-DATABASE]; User Id=[USERT-NAME];Password=[Password]"
				
		- Database-Provider-Package-Name
			- Package for database provider installed
				- Microsoft.EntityFrameworkCore.SqlServer
		- -o
			- Switch to specify the Folder Name in application where Entity Classes and Data Access Operation class is created. Generaly name is 'Models'  
		- -t
			- Switch to specify name of the tabel which will be mapped and entity class will be genberated from it.
			- If this switch is not specified then all tables will be used

- Commands used in CodeFirst Approach
	- Create Entity class and DbContext class
		- Entity class(es) will have public properties
		- DbContext class will have connection string and fluent APIs , and DbSet properties
	- Generate Db Migrations using Following command
		- dotnet ef migrations add [MIGRATION-NAME] -c [NAMESSPACE-PATH-TO-DBContecxt-Class] 
		- e.g.
			- dotnet ef migrations add firstMigration -c CS_EF_DB_First.MyAppDbContext 
		- This command will add 'Migrations' folder in project and it will contain files for DB Creation Script
	- Execute command to Generate Database and Tables based on Migrations
		- dotnet ef database update  -c [NAMESSPACE-PATH-TO-DBContecxt-Class] 
		- e.g.
		 - dotnet ef database update  -c CS_EF_DB_First.MyAppDbContext 

````sql
Create database UCompany;

-- use databse

Use UCompany


USE [UCompany]
GO

/****** Object:  Table [dbo].[Department]    Script Date: 12/8/2023 12:14:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Department](
	[DeptNo] [int] NOT NULL,
	[DeptName] [varchar](200) NOT NULL,
	[Location] [varchar](100) NOT NULL,
	[Capacity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DeptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO




USE [UCompany]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 12/8/2023 12:15:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[EmpNo] [int] NOT NULL,
	[EmpName] [varchar](200) NOT NULL,
	[Designation] [varchar](200) NOT NULL,
	[DeptNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([DeptNo])
REFERENCES [dbo].[Department] ([DeptNo])
GO


````

dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=UCompany;Integrated Security=SSPI" Microsoft.EntityFrameworkCore.SqlServer -o Models 

# ASP.NET Core API
- Microsoft.AspNetCore.App
	- ASP.NET Core Runtime having following features
		- Hosting
			- Provides and manages hosting on 'Reverse Proxy'
			- Manages
				- Dependency Injection (DI) Container
				- Session
				- Caching
				- Security
				- MVC / Razor / API / Swagger / gRPC / SignalR Procesing
				- Manages Lifecycle of All Dependencies in DI Container
				- Manages HTTP Request Pipeline using Middleware
	- Program.cs
		- Entry Point to ASP.NET Core App
		- Create Host Builder using WebApplication class with following settings for the App
			- DI Services in DI Container
				- Register all Internal and Extenal Dependencies using 'ServiceDescriptor' class and provoides internal Lifecycle Management for all dependencies those are registered as 'Services'
				- The 'IServiceCollection' interface to register all services
				- Methods of ServiceDescriptor class to manages lifecycle of all these services
					- Singleton Registertaion method 'AddSingleton()'
					- State of object managed for a session aka Scopped with methods as 'AddScopped()'
					- State of the object managed for a current request aka Transient with method as 'AddTransient()'  
						- Database
						- Custom Services 
			- Accessing all keys those are present in the Configuration using 'Configuration'
				- The appsettings.json file will be accessed using Configuration of the type 'IConfiguration' contract
					- Loging, Database Conection string, Token Signeture, anuy other custom configuration 
			- Web Application Core Service Options, internally uses IServiceCollection and provides an internal lifecycle management
				- Session, Caching, Swagger, CORS, Identity
				- RazorPages for Razor Views
				- ControllersWithView, for MVC and API both
				- Controllers, especially for API
			- Middleware
				- They are Components those will be added in Http-Request-Pipeline, represented using the 'HttpContext' class for Following
					- Exception, Cross-Origin-Resource-Sharing (CORS), Static File Access, Authentication, Authorization, Routing, Cahcing, Session, Custom, etc.	

- API Controllers
	- It is a class that is requested over HTTP
	- It is used to expose Public HTTP Endpoints so that HTTP Requests can be accepted from client
	- This defines 'Action Methods' those will be executed based on HTTP Requests
		- Action Methods, these are the methosd those are mapped with HTTP Request and will be invoked based on the type of HTTP Request
			- HTTP Request Type
				- Get
				- Post
				- Put
				- Delete
	- Technically
		- The 'ControllerBase', the base class for APIController
			- This contains Mechanism to Process HTTP Request and contains methods to Generate HTTP Responses
		- The ApiControllerAttribute class, used as '[ApiController]' as an metadata on Custom Api Controller class
			- This used to Read HTTP Request Body for HTTP POST and PUT method and maps the Received JSON data from HTTP request body to the CLR clas /  Entity Class input parameter to POST and PUT Actions methods   
		- RouteAttribute, the class for Routing and applied on Api Controller class as metadata appribute '[Route]'
			- Maps the Http Reuqest URL with Controller class and its Http Action Method
				- e.g.
					- https://server:PORT/api/controller
						- The 'https' is request schema
						- The server:PORT, a Address of the Host
						- The 'api' (optional but generally used) generally a keyword that specifies that the request is made to REST API
						- The 'controller' the Name of the controller to which the request will be send
							- E.g. Of Controller Name is 'DepartmentController', then the value of the 'controller' will be 'Department', note the word 'Controller' will be filtered out 
		- The Http Method Attribute classes
			- HttpGetAttribute, used as [HttpGet] and its is map the HttpGet Request with Get() Action Method
				- HttpGet("{ROUTE-TEMPLATE}")
					- ROUTE-TEMPLATE, the additional value passed in HTTP Request URL
					- e.g.
						- https://server:PORT/api/controller/id
							- The 'id' is by default Route Parameter 
			- HttpPostAttribute, used as [HttpPost] and its is map the HttpPost Request with Post() Action Method 
			- HttpPutAttribute, used as [HttpPut] and its is map the HttpPut Request with Put() Action Methosd
			- HttpDeledteAttribute, used as [HttpDelete] and its is map the HttpDelete Request with DEelete() Action Method 
		- The 'IActionResult' Contract interface
			- Is a Return type from each Http Action Method 
			- By default it is a type of JSON Result or Http Status Code Result
				- Ok(), NotFound(), COnflict(), BadRequest(), Created(), etc. 
				- 
- Controller Design Guidelines
	- The Controller MUST not Contains Complex Business Logic
	- The Controller MUST not Directly Access the Database
	- All Action Methods from the Controller Should Return a Common Schema As a Response That contains the Success Response as well as Error Messages if Any
	- Controller MUST do Following
		- Authenticate Each request
		- Validate POST and PUT Data
		- Organize the Response
		- Handle Exception
			- try..catch 

# ASP.NET Core Programming Extensibility
- Validations
	- Data Validations, the System.ComponentModel.DataAnnotations namespace with the 'ValidationAttribute' abstract class. This class has the 'IsValid()' method to validate input Parameter
		- Standard Validations
			- RequiredAttribute
			- StringLengthAttribute
			- RegExAttribute
			- .... and so on 
		- Custom Validations
			- Define class derived from the ValidationAttribute and Override the IsValid() method 
	- Exceptions
		- Controller Level Exceptions, including Action Methooid Specific or for all actions in a controller
			- try..catch block
			- Use Action Filters if some logic to be commonly executed only for MVC and API Controllers or their Action Methods (IMP Note: If using Razor Views in Same MVC and API projects, the avoid using ActionFilters, instead use Middlewares)
				- ActionFilterAttribute class, the base class for All Filtres
					- AuthenticationFilter (Used throguh the Identity Middleware)
					- AuthorizationFilter (Used throguh the Identity Middleware)
					- ResourceFilter (Check for Controller and Action Methods)
					- ActionFilter (Custom Filter)
					- ResultFilter (Eveluate the IActionResult)
					- ExcpetionFilter (If Exception Filter is used for Controllers then Do not write and use Exception Middleware)
				- Filters can be applied at Global Level, Controller Level, and Action Level
				- Order of Execution of Filters
					- Global OnActionExecuting
					- Controller OnActionExecuing
					- Action Method OnActionExecuting
					- Action Method OnActionExecuted
					- Controller OnActionExecuted
					- Global OnActionExecuted
					
		- Exception for whole HTTP Pipeline
- Request Management from Client
	- Accepting and Processing Request received from Client
		- Cross Origin resource Sharing (CORS)
	- Identity Validations for Request
		- Authentication and Authorization
			- User Based Authentication
			- Role and Policy Based Authorization 

- Using HttpClient Class
	- System.Net.Http namespace
		- GetAsync(), PostAsync(), PutAsync(), and DeleteAsync()
		- JSON Extension Methods
````csharp
			- GetAsJsonAsync<T>(), PostAsJsonAsync<T>(), etc. 
````
			- T is the Generic Type that will be received from REST API or to be posted to REST API 


- Using Middleware Technically
	- A 'RequestDelegate' delegate
		- A Delegate that invokes the Midleware in HTTP request pipeline
````csharp
	public delegate Task RequestDelegate(HttpContext context);

	public async Task InvokeAsync(HttpContext contect) { /*LOGIC*/  }
````
		- InvokeAsync() method that contains the logic of Middleware  
	- IApplicationBuilder Contract
		- IMiddleware Contract Interface
		- The 'Use()' of  IApplicationBuilder, to register the Middleware in HTTP Pipeline
````csharp
		UseMiddleware<T>(this IApplicationBuilder builder)
		{
		   /* LOGIC to register*/
		}
````
		- The  'T' is the Middleware class that is constructor injected using the 'RequestDelegate' 

# ASP.NET Core Security

- Microsoft.AspNetCore.Identyity
	- A BAse Framework for Security 
- Microsoft.AspNetCore.Identyity.EntiryFrameworkCore
	- Provides a Code-First Approach to create a Database and Identity Table Schemas to store Users, Roles, etc. Information in Database
- System.IdentityModel.JwtBearer
	- For JSON Web Tokens 

- Object Model
	- IdentityUser
		- Used to Create and Manage Users
	- IdentityRole
		- Used to Create and Manage Roles
````csharp
	- UserManager<IdentityUser>
		- Used to Manage Application Users to Create , Read, Update
		- Takes care of PasswordHash
		- Assign Role to User
	- RoleManager<IdentityRole>
		- Used to Manage Application Role to Create , Read, Update
	- SignInManager<IdentityUser>
		- Used to Manage the SignIn and SignOut
		- Used to define Identity Cookie for Login User

	- Identity Services to be added in DI Container
		- The 'AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStore<DbContext>()'
			- AddIdentity<IdentityUser,IdentityRole>(), register the 'UserManager<IdentityUser>' and  'RoleManager<IdentityRole>' and 'SignInManager<IdentityUser>' classes in DI Container
			- AddEntityFrameworkStore<DbContext>()
				- Please Note that the DbContext class MUST be already registered in DI Container using 'AddDbContext()' method
				- Configure the EF Core DbContext class with Idenitty Service to provide DB infromation where the Application Users and Role are stored
		- If using the Tokens then to validate the Toke use
			- AddAuthorization() method for Token Validation Service
		- UseAuthentication()
			- Middleware for USer-BAsed Authentication
		- UseAuthorization()
			- Middlewsare for Role-Based Authorization
````
	
- Command to Generate Migrations for AspNet Security
	- dotnet ef migrations add securityMigration -c Core_API.Models.CapSecurityDbContext
- Command to generate the security database based on the Migrations
	- dotnet ef database update -c Core_API.Models.CapSecurityDbContext 
