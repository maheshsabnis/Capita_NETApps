using CS_Interface_System.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Interface_System.LoggerGateway
{
    internal class AppLoggerGateway
    {
        ILogger logger;
        /// <summary>
        /// FActory Constructor that is setting a ILogger instance 
        /// based on Configuration string logType
        /// </summary>
        /// <param name="logType"></param>
        public AppLoggerGateway(string logType)
        {
            if (logType == "text")
                logger = new TextLog();
            if (logType == "json")
                logger = new JsonLog();
        }

        public void Write(string message)
        {
            logger.WriteLog(message);
        }

        public string Read()
        {
            return logger.ReadLog();
        }


    }
}
