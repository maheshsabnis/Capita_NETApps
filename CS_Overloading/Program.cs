// See https://aka.ms/new-console-template for more information
using CS_Overloading.Logic;

Console.WriteLine("DEMO Overloading");
StringOperations op = new StringOperations ();

Console.WriteLine($"One Parameters : {op.Concat("C# is Best")}");
Console.WriteLine($"Two Parameters : {op.Concat("C# is Best", "for .NET App Development")}");
Console.WriteLine($"Two Parameters with an Array : {op.Concat("C# is Best", new string[] { "For Desktop", "For Web", "For Mobile" })}");
Console.WriteLine($"One Parameters : {op.Concat("C# is Best with Version", 7)}");
Console.WriteLine($"One Parameters : {op.Concat(7, "C# is Best")}");

Console.ReadLine();
