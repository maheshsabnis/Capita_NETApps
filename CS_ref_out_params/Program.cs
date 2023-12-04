// See https://aka.ms/new-console-template for more information
using CS_ref_out_params;

Console.WriteLine("DEMO Ref Out Params");
Processing processing = new Processing();
int a = 10, b = 20;

Console.WriteLine($"Before passing a = {a} and b = {b}");
// default passing 'by val'
// to pass by referenvce uss the ref keyword
processing.XChange(ref a,ref b);
Console.WriteLine($"After XChange call from Main()  a = {a} and b = {b} ");

decimal Salary = 60000;
decimal Tds;
processing.GetTDSAndIncome(Salary, out Tds, out decimal NetIncome);

Console.WriteLine($"For Salary = {Salary}, TDS = {Tds} and NetIncome = {NetIncome}");


Console.WriteLine($"Add with 2 Paramneters : {processing.Add(2,3)}");
Console.WriteLine($"Add with 3 Paramneters : {processing.Add(2, 3,4)}"); // params 4
Console.WriteLine($"Add with 4 Paramneters : {processing.Add(2, 3,4,5)}"); // params 4,5
Console.WriteLine($"Add with 5 Paramneters : {processing.Add(2, 3,4,5,6)}");// params 4,5,6
Console.WriteLine($"Add with 6 Paramneters : {processing.Add(2, 3,4,5,6,7)}");// params 4,5,6,7

Console.ReadLine();
