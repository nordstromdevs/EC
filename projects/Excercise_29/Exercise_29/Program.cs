using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_29
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log = new Logger();

            log.Log("Hello World!");
            log.Log("Application started");

            var currentLog = log.GetLog();
            Console.WriteLine(currentLog);

            Console.ReadKey();

        }
    }
}
