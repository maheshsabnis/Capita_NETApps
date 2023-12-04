/* Imported The NAmespace */
using CS_SimpleMath.Logic;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("DEMo Simple Math");
/* Creating Instance */
Mathematics m = new Mathematics();

/* Accept inputs from End-User*/

Console.WriteLine("Enter x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter y");
int y = Convert.ToInt32(Console.ReadLine());

/* Incoke Class Methods and pass Parameters to it */

int addResult = m.Add(x, y);

Console.WriteLine($"Add = {addResult}");

int multResult = m.Mult(x, y);
Console.WriteLine($"Multiplication {multResult}");




Console.ReadLine();
