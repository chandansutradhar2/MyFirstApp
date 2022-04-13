using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Logger
    {
        private string logPath;
        private string streamReader;
        public Logger(string logPath) {
        this.logPath = logPath;
        Console.WriteLine("Initialized Logger to write into file located at "+logPath);
        }
        //info, warn, error
        public static void Write(string dateTime, string logMsg, LOG_TYPE logType)
        {
            Console.WriteLine($"{dateTime}:{logType}:{logMsg}");
        }
    }

   public enum LOG_TYPE { 
        INFO,
        WARN,
        ERROR,
        FATAL,
        SUCCESS

    }


    class TestDemo {

        void Test() {
            Logger obj = new Logger("");
            //obj.streamReader = "my own logic";

            Logger.Write("02/02/2020", "Server starting", LOG_TYPE.ERROR);

        }
    }
}
