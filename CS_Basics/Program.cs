// See https://aka.ms/new-console-template for more information
using CS_Basics.Logic;

Console.WriteLine("Simple OOPs");

Employee e1 =new Employee (101, "Mahesh", 12000);

e1.GetEmp();


StringOperations stringOperations = new StringOperations ();
string str = "My Name is Bond...James Bond";

Console.WriteLine($"Length of {str} is = {stringOperations.GetLength(str)}");
Console.WriteLine($"Upper Case of {str} is   = {stringOperations.ChangeCase(str, 'U')}");
Console.WriteLine($"Lower Case of {str} is   = {stringOperations.ChangeCase(str, 'l')}");
// The method must modify or set valuye for the out parameter
stringOperations.GetWhiteSpaces(str, out int count);
Console.WriteLine($"Count of Blank Spaces in {str} is = {count}");

Console.ReadLine();
