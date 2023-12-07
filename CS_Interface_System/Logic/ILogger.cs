using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_System.Logic
{
    internal interface ILogger
    {
        void WriteLog(string message);
        string ReadLog();
    }
}
