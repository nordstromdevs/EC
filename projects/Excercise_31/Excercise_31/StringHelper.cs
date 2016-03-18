using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_31
{
    public static class StringHelper
    {
        public static int NumberOfWords(this string input)
        {
            var result = input.Split(' ').Length;
            return result;
        }
    }
}
