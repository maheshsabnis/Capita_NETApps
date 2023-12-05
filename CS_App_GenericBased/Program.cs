// See https://aka.ms/new-console-template for more information
using CS_App_GenericBased.Entities;
using CS_App_GenericBased.Logic;

Console.WriteLine("DEMO Generic BAsed App");
Operation<Director> operationDirector = new Operation<Director>();

operationDirector.Add(new Director() { EmpNo = 1, EmpName = "A", DeptName = "D1", Salary = 333, HRA = 33, MobileAllowance = 3223 });

Operation<Manager> managerOperation = new Operation<Manager>();
managerOperation.Add(new Manager() { EmpNo=2,EmpName="S",DeptName="FR",Salary=22,FoodAllowance=22,TA=55});


Operation<Employee> empOp = new Operation<Employee>();
empOp.Add(new Director() { });
empOp.Add(new Manager() { });

Console.ReadLine();
