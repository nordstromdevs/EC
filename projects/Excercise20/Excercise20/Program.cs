using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            ListLoader loader = new ListLoader();
            var myList  = loader.Load();

            Console.Write("Enter search term: ");
            string searchTerm = Console.ReadLine();

            var filter = new Filter();
            var filteredList = filter.Search(myList, searchTerm);

            foreach (var item in filteredList)
                Console.WriteLine(item);

            Console.ReadKey();

        }
    }
}
