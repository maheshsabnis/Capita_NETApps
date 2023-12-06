// See https://aka.ms/new-console-template for more information
using CS_Task_Continue.Logic;

Console.WriteLine("Task Continue");

Task t1 = Task.Factory.StartNew(() =>
{
    Console.WriteLine("Task 1");
    Thread.Sleep(1000);
}).ContinueWith((t) =>
{
    Console.WriteLine($"State of T1 : {t.IsCompletedSuccessfully}");
    Console.WriteLine(" Task 2 Continue");
    Thread.Sleep(1000);
}).ContinueWith((t) => 
{
    Console.WriteLine($"State of T2 : {t.IsCompletedSuccessfully}");
    Console.WriteLine(" Task 3 Continue");
});
Console.WriteLine(  );
Console.WriteLine();

/* Continue Task with Return value from Previous Task to Next Task */
Processing p = new Processing();
Task<decimal> t2 = Task.Factory.StartNew<decimal>(() => 
{
    decimal netsal = p.GetSalary(6700000);
    return netsal;
})
    /*ContinueWith <T> is responsible to read the Task from the Previous Task using the Runtime */
    .ContinueWith<decimal>((tsal) => /* tsal is the task object from previouds task */ 
{
    // Result of Previous task
    decimal tds = p.GetTDS(tsal.Result);
    return tds;
});

Console.WriteLine($"The tax : {t2.Result}");

Console.ReadLine();
