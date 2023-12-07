// See https://aka.ms/new-console-template for more information
using CS_Interface.Logic;

Console.WriteLine("DEMO Interface");

// 1. Accessing method using Class INstance
Mathematics m1 = new Mathematics();
Console.WriteLine($"Add : {m1.Add(4,5)}");
Console.WriteLine($"Power : {m1.Power(10,5)}");

// 2. Accessing methods using Interface Reference of which instance is created using class
// Since Mathematics class implements IMath interface, the below statement will be compiled
IMath m2 = new Mathematics();
Console.WriteLine($"Add with m2 : {m2.Add(40, 5)}");
Console.WriteLine($"Power with m2: {m2.Power(7, 5)}");


 
IMath m3  = new MathematicsExplicit();
Console.WriteLine($"Add with m3 : {m3.Add(40, 5)}");
Console.WriteLine($"Power with m3: {m3.Power(7, 5)}");

INewMath m4 = new MathematicsExplicit();
Console.WriteLine($"Add with m4 : {m4.Add(40, 5)}");
Console.WriteLine($"Power with m4: {m4.Power(7, 5)}");



Console.ReadLine();