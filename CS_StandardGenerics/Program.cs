using CS_StandardGenerics;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMO Generics!");

List<int> intList = new List<int>();
intList.Add(10);
intList.Add(20);
intList.Add(30);
intList.Add(40);

foreach (int i in intList)
{
    Console.WriteLine($"INT = {i}");
}
Console.WriteLine();
List<string> strList = new List<string>();
strList.Add("A");
strList.Add("B");
strList.Add("C");
strList.Add("D");

foreach (string str in strList)
{
    Console.WriteLine($"STRING = {str}");
}

Console.WriteLine(  );
List<Employee> emps = new List<Employee>();
// Object Initialization for Employeee
emps.Add(new Employee() {EmpNo=1,EmpName="A" });
emps.Add(new Employee() { EmpNo = 2, EmpName = "B" });
emps.Add(new Employee() { EmpNo = 3, EmpName = "C" });
emps.Add(new Employee() { EmpNo = 4, EmpName = "D" });

foreach (Employee emp in emps)
{
    Console.WriteLine($"EmpNo : {emp.EmpNo} and EmpName : {emp.EmpName}");
}

Console.ReadLine();    
