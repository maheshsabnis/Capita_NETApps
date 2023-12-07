# Date : 01-Dec-2023

1. (LAB): Create a Class with methods to store Employee Information, read and update the information

2.	(LAB): Create a Employee abstract class by containing abstract methods for Read and Write Employee Information. Add the Virtual method to calculate Salary.
3.	(LAB): Derive the Manager, Consultant, and Software Engineer classes from Employee class and override all methods of the Employee class.


# Date: 04-Dec-2023

1. Creating a Abstract Factory that will calculate the salary of each employee (Already created in the CS_App Project)
2. Modify the DirectorLogc and ManagerLogic and otehr Logic classes created on 01-Dec-2023 Lab-3 to have the data of corresponding Entity class store in the Corresponding Collection, e.g.
````csharp
	List<Director>, List<Manager>, List<Consultant>, etc.
````

	- Calculate TDS, Gross and NetIncome for Each Employee and Show the Result for each employee on Console Window (Use out for tds, gross and net income)
	- (Optional but attempt), print NetIncome of each employee in String format
		- e.g. If NetIncome is 45678, the print it as Fourty Five Thousand Six Hundred Seventy Eight only

# Date: 05-Dec-2023

1. Modify the CS_App Project to have a Generic class that will creating List for all desinations of employees. This generic class will contain mathos for Create, Read, Update, and Delete for all employee types,
	- This class will also contains a method   to return an employee / employees based on	following
		- EmpNo
		- EmpName
		- DeptName
		- EmpName and DeptName

# Date: 06-Dec-2023

1.	(LAB): Using Parallel class to Process all employees to calculate NetSalary and Tax for each salary using Parallel.ForEach Method. Use 'out' Parameters to return NetSalary and Tax  

# Date: 07-Dec-2023

 	(LAB): Create an application that will query to Employee collection for performing the following
1.	Sort all Employees by Salary
2.	Sort all Employees by EmpName
3.	Group all Employees by DeptName
4.	Get the Second Max Salary
