// See https://aka.ms/new-console-template for more information
using CS_Delegate.Logic;



Console.WriteLine("Using Delegates");
// Direct Access of the Method

Operation op = new Operation();
Console.WriteLine($"Direct Access : {op.Add(2,3)}");

// 1. Declare a delegate type and pass method address to it
// The name of tye method is Method address
OperationHandler h1 = new OperationHandler(op.Add);
// 2. Pass paramneters to delegate type so that it will invoke the method
Console.WriteLine($"Access with Delegate Add = {h1(10,20)}");
// 3. Anonymous Method, directly pass implementation to a delegate
OperationHandler h2 =   delegate (int x, int y) { return x * y; };
Console.WriteLine($"C# 2.0 Anonymous Method : {h2(122,33)}");
// 4. C# 3.0 Lambda Expression
// English Meaning for Lambda Expression is: The parameter a and b are passed to the method and it returns a * b
OperationHandler h3 = (int a, int b) => { return a * b; };
Console.WriteLine($"C# 3.0 Lambda Expression : {h3(100,200)}");

// Call the PrintResult() and pass Lambda Expression ot it

PrintResult((p, q) => { return p * q; });



Console.ReadLine();

/// a Method with input parameter as delegate 
static void PrintResult(OperationHandler h)
{
    Console.WriteLine($"Resulr : {h(100,20)}");
}