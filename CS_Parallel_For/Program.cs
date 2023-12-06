// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("DEMO Parallel Class");

Console.WriteLine("The Sequential Execution");

// create a timer
var sequentialTimer =  Stopwatch.StartNew();
var empList = new EmployeeList();

for (int i = 0; i < empList.Count; i++)
{
    empList[i] = ProcessTax.CalculateTax(empList[i]);
    Console.WriteLine($"Tax for EmpNo : {empList[i].EmpNo} is = {empList[i].TDS}");
}
Console.WriteLine($"Total Time for1 Sequential Execution for is : {sequentialTimer.Elapsed.TotalMilliseconds}");

Console.WriteLine("Sequential Execdution Ends");
Console.WriteLine();
Console.WriteLine("Using Parallel Execution");
var parallelTimer = Stopwatch.StartNew();

Parallel.For(0, empList.Count, (i) => {
    empList[i] = ProcessTax.CalculateTax(empList[i]);
    Console.WriteLine($"Tax for EmpNo : {empList[i].EmpNo} is = {empList[i].TDS}");
});

Console.WriteLine($"Total Time for1 Parallel Execution for is : {parallelTimer.Elapsed.TotalMilliseconds}");

Console.WriteLine("Parallel Execdution Ends");
Console.WriteLine();


Console.ReadLine();
