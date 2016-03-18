using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_31
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hej allihopa hur är läget?";
            //var result = StringHelper.NumberOfWords(myString);

            var result = myString.NumberOfWords();

            Console.WriteLine("Result = " + result);
            Console.ReadKey();
        }
    }
}
