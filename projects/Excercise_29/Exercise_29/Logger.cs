using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_29
{
    class Logger : ILog
    {
        private const string FILENAME = @"C:\Temp\LogFile.log";

        public string GetLog()
        {
            string result = string.Empty;

            StreamReader reader = new StreamReader(FILENAME);
            string line = string.Empty;

            while((line = reader.ReadLine()) != null)
            {
                result += line + Environment.NewLine;
            }

            reader.Close();

            return result;
        }

        public void Log(string message)
        {
            StreamWriter writer = new StreamWriter(FILENAME, true);
            string output = DateTime.Now.ToString() + " : " + message;
            writer.WriteLine(output);
            writer.Close();

            //using (StreamWriter writer = new StreamWriter(FILENAME, true))
            //{
            //    string output = DateTime.Now.ToString() + " : " + message;
            //    writer.WriteLine(output);
            //}
        }
    }
}
