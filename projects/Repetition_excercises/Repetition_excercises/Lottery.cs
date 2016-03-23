using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_excercises
{
    class Lottery
    {
        private static Random rnd = new Random();

        public static int GenerateNumber()
        {
            int result = rnd.Next(1, 36); // will return 1-35

            return result;
        }

        public static List<int> GenerateNumbers()
        {
            List<int> result = new List<int>();

            while (result.Count < 7)
            {
                int number = rnd.Next(1, 36); // will return 1-35
                if (!result.Contains(number))
                    result.Add(number);
            }

            return result;
        }
    }
}
