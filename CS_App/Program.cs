// See https://aka.ms/new-console-template for more information
using CS_App.AccountingSys;
using CS_App.Entities;
using CS_App.Logic;
using System.Text.Json;

Console.WriteLine("OOPs Application");
// Instance of Director Logic using a Reference of Base Class EmployeeLogic
EmployeeLogic logic = new DirectorLogic();
/// Object Initialization
/// The Base class reference is initialized using an instance of Derived class
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


Accounts accounts = new Accounts();

foreach (Employee emp in empDirectors)
{
    Console.WriteLine($"Income : {logic.GetIncome(emp)}");
    /// Gte the NetIncome for Directors 
    /// The Type of emp is Director and type of logic is DirectoryLogic at Runtime
    Console.WriteLine($"Net Income of Employee : {emp.EmpName} is {accounts.GetNetIncome(emp,logic)}");
}

Employee e3 = new Manager()
{
     EmpNo =1001,
      EmpName= "Ajay",
      DeptName = "HRD",
      Salary = 1000,
      FoodAllowance = 500,
      TA =300
};


// Get Net Income for Manager
// Instance of Manager Logic using a Reference of Base Class EmployeeLogic
logic = new ManagerLogic();
/// The Type of e3 is Manager and type of logic is ManagerLogic at Runtime
Console.WriteLine($"Net Income of Manager EmpName : {e3.EmpName} is = {accounts.GetNetIncome(e3, logic)}");




Console.ReadLine();
