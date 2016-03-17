using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    class ListLoader
    {
        public List<LanguageData> LoadData()
        {
            var result = new List<LanguageData>();

            var reader = new StreamReader("languageData.txt");

            string line = "";

            while ((line = reader.ReadLine()) != null)
            {
                var name = line.Split('\t')[0];
                var year = int.Parse(line.Split('\t')[1]);
                var description = line.Split('\t')[2];

                var splitResult = line.Split('\t');
                if (splitResult.Length == 3)
                {

                }

                var langData = new LanguageData {
                    Description = description,
                    Name = name,
                    Year = year
                };

                result.Add(langData);
            }

            return result;
        }

        public void SaveData(List<LanguageData> list)
        {
            StreamWriter writer = new StreamWriter("filteredResult.txt");
            
            foreach (var item in list)
            {
                var output = string.Format($"{item.Name}\t{item.Year}\t{item.Description}");
                writer.WriteLine(output);
            }
            
            writer.Close();
        }


    }
}
