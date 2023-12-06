// See https://aka.ms/new-console-template for more information
using CS_Parallel_Invoke.Logic;
using System.Diagnostics;

Console.WriteLine("DEMO Parallel Invoke");

FileOperations fileOperations = new FileOperations();

// SYnchornous Read by calling each method

var timer = Stopwatch.StartNew();

string james = fileOperations.ReadJames();
Console.WriteLine($"James Bond: {james}");

string ethan =  fileOperations.ReadEthan();
Console.WriteLine($"Ethan Hunt: {ethan}");



Console.WriteLine($"Sequential Synchornous Read Time for Both File is = {timer.Elapsed.TotalMilliseconds}");

Console.WriteLine("Using Parallel.Invoke");
var timer1 = Stopwatch.StartNew();

Parallel.Invoke(() => {
    string james1 = fileOperations.ReadJames();
    Console.WriteLine($"James Bond: {james1}");

    string ethan1 = fileOperations.ReadEthan();
    Console.WriteLine($"Ethan Hunt: {ethan1}");
});



Console.WriteLine($"Paralle  Read Time for Both File is = {timer1.Elapsed.TotalMilliseconds}");


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("On Caller Main Thread");
}

Console.ReadLine();
