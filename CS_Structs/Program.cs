// See https://aka.ms/new-console-template for more information
Console.WriteLine("Workign with Conditional Statements");
string str = "Mahesh"; // Declared and Initialtied Immediately, allocation takes place

Console.WriteLine("Enter Value for Name");

// Use the 'nullable' Reference types (C# 9.0+) to avoid Compiler Warning  
string? name = Console.ReadLine();

//if (name.Length > 0 name == "") //Avoid this
if(!String.IsNullOrEmpty(name)) // Use this instead
{
    Console.WriteLine($"Name = {name}");
}
else
{
    Console.WriteLine("No Value Passed");
}


Console.ReadLine();
