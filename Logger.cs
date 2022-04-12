using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Logger
    {
        string logPath;
        public Logger(string logPath) {
        this.logPath = logPath;
        Console.WriteLine("Initialized Logger to write into file located at "+logPath);
        }
        //info, warn, error
        public void Write(string dateTime,string logMsg, LOG_TYPE logType) {
            Console.WriteLine($"{dateTime}:{logType}:{logMsg}");
        }
    }

    enum LOG_TYPE { 
        INFO,
        WARN,
        ERROR,
        FATAL,
        SUCCESS

    }
}
