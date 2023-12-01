// See https://aka.ms/new-console-template for more information
Console.WriteLine("Box/UnBox");

int i = 10;
object o = i; // Box

Console.WriteLine($"Type in O = {o.GetType()} and value is {o}");

// UnBox

int j = (int)o; // UnBox

Console.WriteLine($"j = {j}");

Console.ReadLine();