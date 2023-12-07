// See https://aka.ms/new-console-template for more information
using CS_Async_Await.Logic;

Console.WriteLine("DEMO Async Await");
// async: Applied on Method whihc has an Async Execution over implicitly allocated and managed threads by .NET Runtime
    // In .NET all method ends with 'XXXXXAsync' returns TAsk object can they are accessed using 'await' keyword 
// await: Applied on the statement that perform method call which will be executed asynchornously 

// If the Main() method is making any awitable calls the runtime will invoke the Main() as 'async' by dfault (.NET Core Feature)

FileOperations fileOperations = new FileOperations();

Console.WriteLine("Main Thread");

var james = await fileOperations.ReadJamesAsync();
Console.WriteLine($"James : {james}");
Console.WriteLine();
Console.WriteLine();
var ethan = await fileOperations.ReadEthanAsync();
Console.WriteLine($"Ethan : {ethan}");
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < 19; i++)
{
    Console.WriteLine($"i on Main Thread {i}");
}

Console.ReadLine();
