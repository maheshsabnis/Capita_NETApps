// See https://aka.ms/new-console-template for more information
using CS_Interface_System.LoggerGateway;

Console.WriteLine("Using Interface");

AppLoggerGateway appLoggerGateway = new AppLoggerGateway("text");

appLoggerGateway.Write("The First Log Message");

Console.WriteLine($"received : {appLoggerGateway.Read()}");



appLoggerGateway = new AppLoggerGateway("json");

appLoggerGateway.Write("The Second Log Message");

Console.WriteLine($"received : {appLoggerGateway.Read()}");



Console.ReadLine();
