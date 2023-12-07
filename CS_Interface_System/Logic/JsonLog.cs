using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_System.Logic
{
    internal class JsonLog : ILogger
    {
        string ILogger.ReadLog()
        {
            return "Log is Read from JSON file";
        }

        void ILogger.WriteLog(string message)
        {
            Console.WriteLine($"Log is Written in JSON File {message}");
        }
    }
}
