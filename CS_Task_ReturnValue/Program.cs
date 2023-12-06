// See https://aka.ms/new-console-template for more information
using CS_Task_ReturnValue.Logic;

Console.WriteLine("Task returning Value");

FileOperations fileOperations = new FileOperations();

Task<string>? t1 = null;

try
{
    /*Task<string>: This object performs an Async Operation taht returns a string  */
    t1 = Task.Factory.StartNew<string>(() =>
    {
        string james = fileOperations.ReadJames();
        /*Value return from Task*/
        return james;
    });
    /* Show the result returnd by the Task on Main Thread*/
    Console.WriteLine($"Value Returned from Task 1: {t1.Result}");
}
catch (Exception ex)
{ 
    Console.WriteLine($"Some Error Occurred isn Task 1 {ex.Message} {t1.Exception}");
}

try
{

    Task<string> t2 = Task.Factory.StartNew<string>(() =>
    {
        string ethan = fileOperations.ReadEthan();
        /*Value return from Task*/
        return ethan;
    });

    Console.WriteLine($"Value Returned from Task 2: {t2.Result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Some Error Occurred Task 2 {ex.Message}");
}




Console.ReadLine();
