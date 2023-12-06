// See https://aka.ms/new-console-template for more information
using CS_TaskObject.Logic;

Console.WriteLine("DEMO Task");

FileOperations fileOperations = new FileOperations();

/*1. Create a Task */
/* The StartNew(), will interact with Runtime and ask for the Thread so that an Async operation can be perfformed on it */
Task t1 = Task.Factory.StartNew(()=> { 
    string james = fileOperations.ReadJames();
    Console.WriteLine($"In Task 1, reading James : {james}");
});
//t1.Wait(); /*BLOCK the Calling Thread for completing its executuion and then Proceed*/
 
Task t2 = Task.Factory.StartNew(() =>
{
    string ethan = fileOperations.ReadEthan();
    Console.WriteLine($"In Task 2, reading Ethan : {ethan}");
});

//t2.Wait();

Task.WaitAll( t1,t2 ); /* Wait for all operations to complete*/

for (int i = 0; i < 10; i++) {
    Console.WriteLine("On Main Thread");
}

Console.ReadLine();