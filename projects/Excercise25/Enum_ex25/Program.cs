using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            var myProcess = new Process();
            Console.WriteLine("Current state: " + myProcess.CurrentState);
            myProcess.Start();
            Console.WriteLine("Current state: " + myProcess.CurrentState);
            myProcess.Pause();
            Console.WriteLine("Current state: " + myProcess.CurrentState);
            myProcess.Stop();
            Console.WriteLine("Current state: " + myProcess.CurrentState);
            myProcess.Start();
            Console.WriteLine("Current state: " + myProcess.CurrentState);
            myProcess.Stop();
            Console.WriteLine("Current state: " + myProcess.CurrentState);

            Console.ReadKey();
        }
    }
}
