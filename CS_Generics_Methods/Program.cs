using CS_Generics_Methods;
using System.Text.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Generic Methods");

// The Generic List Collection for Employees with initial
// Value for Employee. This is known as Collection Initialization
List<Employee> employees = new List<Employee>() 
{
    // This will internally invoke the 'Add()' method of the List class
    new Employee() {EmpNo=1,EmpName="Ajay",DeptName="IT",Salary=22000},
    new Employee() {EmpNo=2,EmpName="Chaitanya",DeptName="HR",Salary=21000},
    new Employee() {EmpNo=3,EmpName="Deepak",DeptName="IT",Salary=20000},
    new Employee() {EmpNo=4,EmpName="Amol",DeptName="HR",Salary=23000},
    new Employee() {EmpNo=5,EmpName="Bhaskar",DeptName="IT",Salary=21000},
    new Employee() {EmpNo=6,EmpName="Chinmay",DeptName="HR",Salary=26000},
    new Employee() {EmpNo=7,EmpName="Abhay",DeptName="IT",Salary=21000},
    new Employee() {EmpNo=8,EmpName="Dinesh",DeptName="HR",Salary=29000},
};

Console.WriteLine($"Employees Count : {employees.Count}");
employees.Remove(employees[3]);
Console.WriteLine($"Employees Count : {employees.Count}");

Console.WriteLine("Entre the DeptName to filter data from employees");
string dname = Console.ReadLine();

foreach (var emp in employees)
{
    if (emp.DeptName == dname)
    {
        Console.WriteLine(JsonSerializer.Serialize(emp));
    }
}


 


Console.ReadLine();
