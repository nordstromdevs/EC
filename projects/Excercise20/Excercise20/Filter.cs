using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise20
{
    class Filter
    {
        public List<string> Search(List<string> inputList, string searchTerm)
        {
            List<string> result = new List<string>();
            
            foreach(var item in inputList)
            {
                if (item.ToUpper().Contains(searchTerm.ToUpper()))
                    result.Add(item);
            }

            return result;
        }

        public string GetValue(string input)
        {
            string result = "";

            result = input.ToUpper();

            return result;
        }
    }
}
