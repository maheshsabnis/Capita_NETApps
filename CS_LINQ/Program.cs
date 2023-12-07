// See https://aka.ms/new-console-template for more information
using CS_LINQ;
using System.Net.Http.Headers;
using System.Text.Json;

Console.WriteLine("DEMo LINQ");
// Anonymous type
var obj = new { id=1,name="A" };

EmployeeCollection employees = new EmployeeCollection();

// Reading Employees for IT Department using Traditional Approach

//foreach (Employee employee in employees)
//{
//    if (employee.DeptName == "IT" && employee.EmpName.StartsWith('Y'))
//    {
//        Console.WriteLine(JsonSerializer.Serialize(employee));
//    }
//}

// 1. Imperative LINQ using Expension Methods C# Specific Syntax

var EmpsByDeptName = employees.Where(e=>e.DeptName == "IT");
PrintResult(EmpsByDeptName);
Console.WriteLine();
var EMpsOrderByEmpName = employees.OrderBy(e=>e.EmpName);
PrintResult(EMpsOrderByEmpName);
Console.WriteLine();
var EMpsOrderByEmpNameDesc = employees.OrderByDescending(e => e.EmpName);
PrintResult(EMpsOrderByEmpNameDesc);
Console.WriteLine();
Console.WriteLine("Using Extension methods in sequence of Collection Processing");

var combine = employees.Where(e => e.DeptName == "IT").OrderByDescending(e => e.EmpName);
PrintResult(combine);
Console.WriteLine();
Console.WriteLine( );

// 2. Declarative LINQ using Language Independant Keywords
// a. from: A Range operator, that will point to first record in collection
// b. in: This represent the record is input to the collection
// c. where: Map with the Where<T> extension method
// d. orderby: Map with OrderBy<T> extension method
// e. ascending: An Operator that helps OrderBy<T> method to rearrange the copllection
// f. select: Map to Select<T> extension method to pick each resultant from the collection based on Where<T>

var emps = from emp in employees
           where emp.DeptName == "IT"
           orderby emp.EmpName ascending
           select emp;

PrintResult(emps);

Console.WriteLine(  );

 


Console.WriteLine();
Console.WriteLine("Lest calculate Sum of all Employees Group by each DeptName");

var sumGroupByDeptName = from emp in employees
                             // Ask the Runtime to create employees group based on DeptName
                             // This Group Name will be represented using deptgrp
                             // The Grouping Property e.g. emp.DeptName will be key for each group 
                         group emp by emp.DeptName into deptgrp
                         // print sum of salary for each DeptName 
                         // Anonynmous type
                         select new { 
                           DeptName =  deptgrp.Key,
                           // For Each Employee in Group get Sum of Salary
                           Salary = deptgrp.Sum(e => e.Salary),
                         };

foreach (var emp in sumGroupByDeptName)
{
    Console.WriteLine($"DeptName : {emp.DeptName} and Salary Sum = {emp.Salary}");
}

Console.ReadLine();

static void PrintResult(IEnumerable<Employee> emps)
{
    Console.WriteLine(JsonSerializer.Serialize(emps));
}