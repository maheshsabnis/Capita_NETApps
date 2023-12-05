// See https://aka.ms/new-console-template for more information
using CS_Event.Logic;
using System.Net.Http.Headers;

Console.WriteLine("DEMO Event");
Banking bank = new Banking(60000);
// Subscribe to the Evening Notifier
Notifier notifier = new Notifier(bank);
bank.Deposit(70000);
Console.WriteLine($"After Deposit NetBalance: {bank.GetNetBalance()}");
bank.Withdrawal(126000);
Console.WriteLine($"After Withdrawal NetBalance: {bank.GetNetBalance()}");
Console.ReadLine();
