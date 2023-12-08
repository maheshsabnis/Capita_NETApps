// See https://aka.ms/new-console-template for more information
using CS_EFCore_DbFirst.DataAccess;
using CS_EFCore_DbFirst.Models;
using System.Text.Json;

Console.WriteLine("DEMO EF Core");

DeptDataAccess dataAccess = new DeptDataAccess();

// 1. Gte All Departments
var depts = await dataAccess.GetAsync();
Console.WriteLine($"All Depts : {JsonSerializer.Serialize(depts)}");
// 2. Baed on PK
var dept = await dataAccess.GetAsync(90);
Console.WriteLine($"Single  Dept : {JsonSerializer.Serialize(dept)}");

// 3. Create New

//var newdept = new Department()
//{
//    DeptNo=40,DeptName="Sales",Capacity=400,Location="Mumbai"
//};

//var result = await dataAccess.CreateAsync(newdept);
//Console.WriteLine($"New  Dept : {JsonSerializer.Serialize(result)}");

// 4. Update
var upddept = new Department()
{
    DeptNo = 40,
    DeptName = "Sales",
    Capacity = 600,
    Location = "Mumbai-Andheri-East"
};

var updresult = await dataAccess.UpdateAsync(upddept.DeptNo, upddept);
Console.WriteLine($"Updayte  Dept : {JsonSerializer.Serialize(updresult)}");

// 5. Delete

var deleted = await dataAccess.DeleteAsync(90);
Console.WriteLine($"{deleted}");

Console.ReadLine();
