using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise20
{
    class ListLoader
    {
        public List<string> Load()
        {
            List<string> result = new List<string>();

            StreamReader reader = new StreamReader("languages.txt");
            string line = "";

            //while(line != null)
            //{
            //    line = reader.ReadLine();
            //    if (line != null)
            //        result.Add(line);
            //}

            while((line = reader.ReadLine()) != null)
            {
                result.Add(line);
            }

            reader.Close();

            return result;
        }
    }
}
