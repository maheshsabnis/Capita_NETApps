// See https://aka.ms/new-console-template for more information
using CS_GenericStack.Utilities;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

Console.WriteLine("DEMO Custom Generic Stack");
GenericStack<int> intStack = new GenericStack<int>();
intStack.Push(1);
intStack.Push(2);
intStack.Push(3);
intStack.Push(4);
intStack.Push(5);

Console.WriteLine($"Generic Stack : {JsonSerializer.Serialize(intStack.ShowEntrties())}");
Console.WriteLine($"Popped Value : {intStack.Pop()}");
Console.WriteLine($"Generic Stack : {JsonSerializer.Serialize(intStack.ShowEntrties())}");

GenericStack<string> strStack = new GenericStack<string>();
strStack.Push("A");
strStack.Push("B");
strStack.Push("C");
strStack.Push("D");
strStack.Push("E");

Console.WriteLine($"Generic Stack : {JsonSerializer.Serialize(strStack.ShowEntrties())}");

GenericStack<Product> productStack = new GenericStack<Product>();
productStack.Push(new Product() { Id=1,Name="P1"});
productStack.Push(new Product() { Id = 2, Name = "P2" });
productStack.Push(new Product() { Id = 3, Name = "P3" });
productStack.Push(new Product() { Id = 4, Name = "P4" });
productStack.Push(new Product() { Id = 5, Name = "P5" });
Console.WriteLine($"Generic Stack : {JsonSerializer.Serialize(productStack.ShowEntrties())}");
Console.ReadLine();
