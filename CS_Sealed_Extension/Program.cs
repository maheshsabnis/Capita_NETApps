// See https://aka.ms/new-console-template for more information
using CS_Sealed_Extension.Logic;

Console.WriteLine("HDEMO Sealed and Extension Method");
Accounting accounting = new Accounting();
CustomizedAccounting customizedAccounting = new CustomizedAccounting();
Console.WriteLine($"TDS = {accounting.CalcluateTDS(34567)}");
Console.WriteLine($"GST = {accounting.CalcluateGST(76543)}");
Console.WriteLine($"Service TAX : {customizedAccounting.CalculateServiceTax(45988)}");
Console.WriteLine($"ST Using Extension Method : {accounting.CalculateServiceTax(33333)}");


string str = "The C# Programming Language is great";

Console.WriteLine($"Length of  {str} : {str.GetLength()}");
Console.WriteLine($"Upper case {str} : {str.ChangeCase('u')}");
Console.WriteLine($"Lower case {str} : {str.ChangeCase('L')}");
Console.WriteLine($"Blank Spaces ins {str} : {str.GetWhiteSpaces()}");

 
Console.ReadLine();
