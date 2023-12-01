// See https://aka.ms/new-console-template for more information
using CS_App.Entities;
using CS_App.Logic;
using System.Text.Json;

Console.WriteLine("OOPs Application");

EmployeeLogic logic = new DirectorLogic();

Employee e1 = new Director()
{
   EmpNo = 1, EmpName="E-Dir-1",DeptName="IT",Salary=5000,HRA =500,MobileAllowance=1000 
};

logic.AddEmployee(e1);

Employee e2 = new Director()
{
    EmpNo = 2,
    EmpName = "E-Dir-2",
    DeptName = "IT",
    Salary = 7000,
    HRA = 700,
    MobileAllowance = 2000
};

logic.AddEmployee(e2);


var empDirectors =  logic.GetEmployees();

Console.WriteLine($"Directotrs : {JsonSerializer.Serialize(empDirectors)}");

foreach (Employee emp in empDirectors)
{
    Console.WriteLine($"Income : {logic.GetIncome(emp)}");
}




Console.ReadLine();
