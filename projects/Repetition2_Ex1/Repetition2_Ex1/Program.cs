using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition2_Ex1
{
    class Program
    {
        private const int MAX_NUMBER = 15;
        private const int PADDING = 4;

        static void Main(string[] args)
        {
            for (int y = 0; y < MAX_NUMBER; y++)
            {
                if (y == 0)
                {
                    for (int x = 0; x < MAX_NUMBER; x++)
                    {
                        if (x > 0)
                            Console.Write(x.ToString().PadLeft(PADDING, ' '));
                        else
                            Console.Write(" ".PadLeft(PADDING, ' '));
                    }
                }
                else
                {
                    Console.Write(y.ToString().PadLeft(PADDING, ' '));

                    for (int x = 1; x < MAX_NUMBER; x++)
                    {
                        var value = x * y;
                        Console.Write(value.ToString().PadLeft(PADDING, ' '));
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

    
    }
}
