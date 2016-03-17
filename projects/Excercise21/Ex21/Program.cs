using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new ListLoader();
            var myData = loader.LoadData();

            Console.Write("Start year: ");
            int startYear = int.Parse(Console.ReadLine());
            Console.Write("End year: ");
            int endYear = int.Parse(Console.ReadLine());

            var filteredResult = new List<LanguageData>();

            foreach(var item in myData)
            {
                if (item.Year >= startYear && item.Year <= endYear)
                    filteredResult.Add(item);
            }

            foreach(var item in filteredResult.OrderByDescending(abc => abc.Year))
            {
                Console.WriteLine($"{item.Name}\t{item.Year}\t{item.Description}");
            }

            Console.ReadKey();

            loader.SaveData(filteredResult);
            Console.WriteLine("Saved to file!");
            Console.ReadKey();
        }
    }
}
