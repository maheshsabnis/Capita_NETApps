// See https://aka.ms/new-console-template for more information
using CS_OOPs_Design.Entities;
using CS_OOPs_Design.Logic;

Console.WriteLine("Entity and Domain / Application");
EmployeeLogic logic = new EmployeeLogic();
Employee e1 = new Employee()
{ 
  EmpNo = 1, EmpName = "A",Salary=123,DeptName="IT"
};

logic.AddEmployee(e1);

Employee e2 = new Employee()
{
    EmpNo = 2,
    EmpName = "B",
    Salary = -345,
    DeptName = "HRD"
};

logic.AddEmployee(e2);

Employee e3 = new Employee()
{
    EmpNo = 3,
    EmpName = "V",
    Salary = 567,
    DeptName = "SALES"
};

logic.AddEmployee(e3);


var employees = logic.GetEmployees();

foreach (var emp in employees)
{
    Console.WriteLine($"{emp.EmpNo} {emp.EmpName} {emp.Salary} {emp.DeptName}");
}


Console.ReadLine();
